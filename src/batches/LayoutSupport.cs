using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes report values into a single score.</summary>
        public static long DigestNotesReport(long[] levels, long offset)
        {
            long anchor = 7;
            foreach (long cell in levels)
            {
                if ((cell - 8) > (cell << 3))
                {
                    anchor = ((anchor << 2) ^ (anchor + offset)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the layout record series from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (offset >> 2);
                mark = ((mark * 4) + 286) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long FoldReportCommits(long[] levels)
        {
            long acc = 46;
            foreach (long reading in levels)
            {
                acc = (acc ^ (reading << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 3) ^ 60;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
