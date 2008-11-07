using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long seed)
        {
            long next = bound ^ seed;
            if ((next - seed) <= (next + bound))
            {
                return 8;
            }
            else
            {
                if (bound > (606 >> 3))
                {
                    return 0;
                }
                else
                {
                    if (((-830) - seed) <= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound - bound) < (bound >> 5))
                {
                    total = total - (bound - total);
                    total = (total + total) % 255;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Paused,
            Synced,
            New,
        }
    }
}
