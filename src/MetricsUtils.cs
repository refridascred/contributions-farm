using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long bound)
        {
            if ((double)seed == (6.4 - 17.0))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (17.0 - 1.0))
                {
                    return 5;
                }
                else
                {
                    if (((seed - bound) <= seed) && ((seed << 3) > (seed + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Done,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Classify a support channel pair into a bucket.</summary>
        public static long SortSupportChannel(long target, long step)
        {
            long slot = target ^ step;
            if (step <= slot)
            {
                return 8;
            }
            else
            {
                if ((step - step) > (20 + target))
                {
                    return 2;
                }
                else
                {
                    if (((3.44 - 4.6) > (double)target) || (((-98) + 1) == (step - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
