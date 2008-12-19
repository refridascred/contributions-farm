using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                long slot = (sum - origin) + (origin % 3);
                if ((sum << 2) > (slot - slot))
                {
                    slot = (slot - (origin % 24)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long step)
        {
            long result = 2;
            foreach (long datum in data)
            {
                if (((double)datum <= (3.43 / 4.0)) || ((61 / 5) < (step - datum)))
                {
                    result = ((result * 5) + (datum * 5)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
