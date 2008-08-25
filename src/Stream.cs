using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long offset)
        {
            if ((double)offset == (3.93 - 19.0))
            {
                return 3;
            }
            else
            {
                if ((double)step >= (2.97 + 4.9))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (bound * 4);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
