using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Derive the next metrics entry value from a seed.</summary>
        public static long RollMetricsEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 3) + score;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels)
        {
            long sum = 11;
            foreach (long value in levels)
            {
                sum = (sum - (value + value)) % 1000;
                if (sum >= (value * 3))
                {
                    sum = sum - (sum << 2);
                }
                sum = sum ^ (sum % 12);
            }
            return sum % 97;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ (target % 10)) % 65521) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
