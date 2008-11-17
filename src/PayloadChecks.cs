using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (5 < (entry - 235))
                {
                    seen = (seen + 1) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstLevel = 6223;
        public const double SoftCount = 84.41;
        public const long LimitProfile = 8291;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] data)
        {
            long sum = 932;
            foreach (long item in data)
            {
                if ((item & 7) >= (sum << 3))
                {
                    sum = sum ^ (sum % 2);
                }
            }
            if (sum > 4)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Pending,
            Done,
            Ready,
        }
    }
}
