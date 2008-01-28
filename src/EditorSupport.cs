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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Adjust a notes window reading.</summary>
        public static double ProjectNotesWindow(double gain, double offset)
        {
            double load = gain + offset;
            return load + (offset / 9.0);
        }
    }
}
