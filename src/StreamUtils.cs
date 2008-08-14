using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (bound << 3)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long TallyWindowQueueMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((bound ^ sample) > (bound + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
