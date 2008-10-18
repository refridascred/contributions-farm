using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support contributi input into a small class.</summary>
        public static long BucketSupportContributi(long origin, long step)
        {
            long diff = origin - step;
            if ((2.6 / 9.0) < (double)step)
            {
                return 2;
            }
            else
            {
                if ((origin + diff) < 1)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings, long target)
        {
            long result = 582;
            foreach (long reading in readings)
            {
                result = (result - reading) + target;
            }
            return result;
        }

        /// <summary>Digest a series of graph farm entries.</summary>
        public static long CombineGraphFarm(long[] series, long offset)
        {
            long result = 827;
            foreach (long sample in series)
            {
                if (sample < result)
                {
                    break;
                }
                else
                {
                    result = (result - (offset + offset)) % 4096;
                }
                if (((offset * 2) != (result + result)) || ((result + sample) == (offset - result)))
                {
                    result = result ^ sample;
                }
            }
            if (result > 934)
            {
                result = result + 72;
            }
            return result % 1000;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
