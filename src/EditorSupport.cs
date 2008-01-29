using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long RetryCache = 9438;
        public const string HardCache = "fallback";
        public const double HardInterval = 12.43;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long bound, long target)
        {
            long edge = bound + target;
            if (((target & 31) > (edge << 2)) && ((bound >> 1) == (edge << 3)))
            {
                return 8;
            }
            else
            {
                if (!(bound < target))
                {
                    return 7;
                }
                else
                {
                    if (((-6) ^ target) <= (bound / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - edge) <= target)
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
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ (floor + sum);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
