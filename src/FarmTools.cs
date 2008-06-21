using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset + origin) <= (0 - offset))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= 3.36) || ((double)origin <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 4;
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
