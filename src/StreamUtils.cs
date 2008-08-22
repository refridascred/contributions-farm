using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long bound2)
        {
            if ((bound2 - bound2) > bound)
            {
                return 0;
            }
            else
            {
                if (!(bound2 < (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 << 2) < (bound + bound2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.3 / 9.0) >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "standard-v2";
        public const double WindowRecord = 78.08;
        public const double MinRecord = 53.5;
        public const long BaseSpan = 3216;
        public const double IdleRecord = 26.1;

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinScore = 20.16;
        public const double RetryNotes = 5.79;
        public const long LimitDepth = 6911;
        public const long BatchNotes = 9227;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
