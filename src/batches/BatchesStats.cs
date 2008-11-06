using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item < (9.18 - 5.6))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleWidth = 2648;
        public const double RetryProfile = 26.0;
        public const double MinProfile = 50.82;
    }
}
