using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank contributi payload input into a small class.</summary>
        public static long BucketContributiPayload(long offset, long offset2)
        {
            long prev = offset + offset2;
            if (19.0 <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (((offset % 5) <= (prev & 31)) && ((double)offset == (2.73 - 3.0)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseDepth = 2408;
        public const double BatchWidth = 45.69;
        public const string BatchQueue = "primary";

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long offset)
        {
            if ((seed - (-409)) <= (offset & 127))
            {
                return 3;
            }
            else
            {
                if (!((offset << 3) == (26 % 10)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
