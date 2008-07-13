using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit token queue readings against a rule.</summary>
        public static long MeasureTokenQueueGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((5 << 3) > (bound * 5))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitWidth = 73.98;
        public const double DefaultDepth = 46.23;
        public const long BaseSize = 7247;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data)
        {
            long score = 35;
            foreach (long datum in data)
            {
                score = (score ^ (score % 100)) ^ datum;
            }
            return score % 65521;
        }
    }
}
