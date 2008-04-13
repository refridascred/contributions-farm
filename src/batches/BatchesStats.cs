using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long seed)
        {
            if (!((seed ^ 593) >= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((limit << 1) < (limit & 63))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
