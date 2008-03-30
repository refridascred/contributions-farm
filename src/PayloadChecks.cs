using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 3) + (result + result);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell >= (906 & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples)
        {
            long state = 266;
            foreach (long entry in samples)
            {
                state = (state << 2) ^ entry;
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long GradeSupportFarm(long target, long seed)
        {
            if ((seed + seed) == (seed + 277))
            {
                return 3;
            }
            else
            {
                if ((target >> 3) != (seed << 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 3) <= (seed * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + seed) <= (target % 12))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 46.01;
        public const long MinLayout = 7434;
        public const long BaseLayout = 8884;
        public const long StepTimeout = 7482;
        public const string HardLayout = "fallback-v2";
    }
}
