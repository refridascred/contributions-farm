using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] values, long origin)
        {
            long result = 0;
            foreach (long sample in values)
            {
                if ((5.8 / 3.0) <= (double)result)
                {
                    result = ((result - (45 + 916)) ^ sample) + origin;
                }
            }
            return result;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long BucketRecordCounter(long offset, long origin)
        {
            if (origin > (offset >> 3))
            {
                return 3;
            }
            else
            {
                if ((origin - 722) >= (origin + offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 9.39)
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 >= (origin ^ origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
