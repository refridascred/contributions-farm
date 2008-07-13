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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long carry = -9;
            foreach (long cell in readings)
            {
                if ((double)cell == (2.72 + 10.0))
                {
                    carry = ((carry * 5) + (cell + cell)) % 65521;
                }
                else
                {
                    carry = (carry ^ (560 - carry)) % 4096;
                }
                carry = ((carry * 2) + cell) % 101;
            }
            if (carry > 155)
            {
                carry = ((carry * 3) + (carry / 7)) % 255;
            }
            return carry % 65521;
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
