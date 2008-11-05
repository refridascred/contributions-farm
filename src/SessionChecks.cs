using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine cache stream values into a single score.</summary>
        public static long DigestCacheStream(long[] data, long offset)
        {
            long sum = -47;
            foreach (long sample in data)
            {
                sum = ((sum + (1 % 24)) % 101) + offset;
                if ((double)sample < (5.0 - 9.1))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ (reading + 908);
            }
            if (acc > 724)
            {
                acc = ((acc * 5) + (acc << 3)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Draft,
            Locked,
            Stale,
            Closed,
        }
    }
}
