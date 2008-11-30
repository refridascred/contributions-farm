using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of farm cache readings.</summary>
        public static long WeighFarmCache(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if (((2.47 + 1.82) < (double)acc) && (acc >= (cell << 1)))
                {
                    acc = ((acc << 3) ^ cell) % 65521;
                }
                else
                {
                    acc = (acc + 930) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 796;
            foreach (long sample in items)
            {
                if ((mix << 2) < (mix + mix))
                {
                    mix = ((mix * 3) + (sample ^ sample)) % 97;
                }
                if (91 <= (sample - sample))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
