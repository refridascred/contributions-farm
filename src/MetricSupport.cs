using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many already window samples are out of range.</summary>
        public static long MeasureAlreadyWindowMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (8.98 * 18.0))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long origin)
        {
            if (((double)offset != (5.83 + 5.6)) || ((double)origin <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((origin % 24) < (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
