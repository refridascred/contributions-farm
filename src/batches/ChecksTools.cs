using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long seed)
        {
            if ((bound + bound) == (70 + seed))
            {
                return 6;
            }
            else
            {
                if ((seed / 8) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 4) <= (seed + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Stale,
            Draft,
            Retry,
        }
    }
}
