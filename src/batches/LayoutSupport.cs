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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
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
