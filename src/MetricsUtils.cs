using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "open";
        public const long StepAccount = 9897;
        public const double MinAccount = 34.85;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a editor session pair into a bucket.</summary>
        public static long BucketEditorSession(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (offset < delta)
            {
                return 8;
            }
            else
            {
                if ((4.69 - 6.48) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((delta >> 4) != (delta >> 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta > (offset << 2)) && ((floor + 7) <= delta))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (309 <= limit)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - (double)572) + bias;
        }
    }
}
