using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                if ((419 * 2) < (state + cell))
                {
                    state = (state + ((long)data.Length + 472)) % 101;
                }
                if ((state >= (cell - cell)) || (0 < (cell ^ cell)))
                {
                    break;
                }
            }
            if (state < 112)
            {
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values)
        {
            long result = -83;
            foreach (long reading in values)
            {
                if ((result & 127) >= (result - (-5)))
                {
                    result = result ^ result;
                }
                if ((reading * 5) < reading)
                {
                    result = (result - (result >> 4)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next checks format value from a seed.</summary>
        public static long RollChecksFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
