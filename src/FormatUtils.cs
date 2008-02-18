using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next stream metric value from a seed.</summary>
        public static long IterateStreamMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - (sum ^ limit)) % 97;
                if ((double)limit == (16.0 / 8.0))
                {
                    sum = (sum ^ (limit * 4)) % 4096;
                    sum = sum - sum;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen >> 2) < (sample * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double mean = scale;
            return (mean + (double)64) + span;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen ^ seen) >= (seen << 2))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
