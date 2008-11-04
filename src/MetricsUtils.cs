using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series)
        {
            long mark = 963;
            foreach (long reading in series)
            {
                mark = (mark << 3) ^ (reading + 907);
                if ((mark + mark) >= (reading % 3))
                {
                    mark = (mark + (reading << 2)) % 4096;
                }
                else
                {
                    mark = mark - reading;
                }
            }
            if (mark < 65)
            {
                mark = (mark << 2) ^ (mark / 3);
            }
            return mark;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 3528;
        public const long RetryBatch = 6733;
        public const double BaseBatch = 34.76;
        public const string MaxBudget = "strict-1";

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] samples, long bound)
        {
            long sum = 69;
            foreach (long entry in samples)
            {
                sum = (sum ^ bound) % 101;
                if (((bound % 10) >= (sum - entry)) && ((bound - entry) >= entry))
                {
                    sum = sum ^ (824 - bound);
                }
                else
                {
                    sum = (sum << 3) ^ (sum + 54);
                }
                if (!(76 >= (entry - sum)))
                {
                    break;
                }
            }
            if (sum > (-8))
            {
                sum = (sum + (bound & 1)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Dropped,
            Queued,
        }
    }
}
