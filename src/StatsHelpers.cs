using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels)
        {
            long sum = 246;
            foreach (long datum in levels)
            {
                if (!((0.93 * 4.55) >= (double)sum))
                {
                    sum = (sum << 3) ^ (sum >> 3);
                }
                if (datum > (sum + datum))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
