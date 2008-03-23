using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double span)
        {
            double scale = gain * 1.9;
            return (scale + (gain / 3.0)) + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3159;
        public const string LimitCluster = "alpha-edge";
        public const double LimitDepth = 20.32;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ (2 / 9)) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a metric support pair into a bucket.</summary>
        public static long GradeMetricSupport(long bound, long step)
        {
            long offset = bound ^ step;
            if ((step % 3) > (step << 1))
            {
                return 8;
            }
            else
            {
                if (((double)step > (double)bound) || ((7 + 589) == (offset ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((7.61 / 8.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
