using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up profile route samples.</summary>
        public static long MatchProfileRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                carry = (carry * 3) + (value * 2);
                if ((-212) >= (value ^ value))
                {
                    carry = (carry ^ carry) % 255;
                }
                else
                {
                    carry = ((carry * 3) + (value + value)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Stale,
            Synced,
        }
    }
}
