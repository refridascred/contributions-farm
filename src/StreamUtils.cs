using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long sum = 168;
            foreach (long cell in levels)
            {
                sum = (sum * 5) + cell;
                if (6.7 <= (double)cell)
                {
                    sum = (sum * 5) + (cell << 2);
                }
                else
                {
                    sum = (sum + (sum * 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSize = 67.62;
        public const long CacheSession = 3122;
        public const long HardSession = 7773;
        public const long BatchSession = 1227;
        public const long LimitSession = 9493;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Idle,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound + target;
            if (span <= (588 << 2))
            {
                return 4;
            }
            else
            {
                if (!((span & 127) > (-7)))
                {
                    return 2;
                }
                else
                {
                    if ((span << 2) == (target % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (span < (target << 3))
                        {
                            return 8;
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
