using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Stale,
            Closed,
            Pending,
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

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items, long floor)
        {
            long total = 50;
            foreach (long value in items)
            {
                total = (((total * 5) + (floor + (long)items.Length)) % 1000) ^ value;
                total = (total ^ (893 % 5)) % 1000;
            }
            return total;
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
