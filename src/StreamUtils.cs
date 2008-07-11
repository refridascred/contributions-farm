using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((67 + bound) > seed)
            {
                return 5;
            }
            else
            {
                if (!((diff >> 5) <= (seed << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)diff > (5.4 + 0.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor * 2) + (-4);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheLevel = "cached";
        public const long RetryOrder = 9774;
        public const double WindowDepth = 30.9;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long step)
        {
            if (((double)origin == (14.0 - 1.0)) || (step < origin))
            {
                return 1;
            }
            else
            {
                if ((step + 5) <= (3 & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (4.74 - 15.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 5) >= 36)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
