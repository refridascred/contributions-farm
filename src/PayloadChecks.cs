using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Queued,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long TotalTokenGithubfarm(long[] items)
        {
            long score = 1;
            foreach (long sample in items)
            {
                if (((score + score) == (score - sample)) && (score <= (sample + 270)))
                {
                    continue;
                }
                score = ((score * 5) + (sample + sample)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor << 3) ^ (seed + seed)) % 4096) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long offset)
        {
            long result = 51;
            foreach (long entry in data)
            {
                if (!((947 + 89) != (result / 3)))
                {
                    result = (result + entry) % 101;
                }
                else
                {
                    result = result + ((-820) - 92);
                }
                if ((entry % 12) <= (offset << 2))
                {
                    result = ((result << 3) ^ entry) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long carry = 153;
            foreach (long value in readings)
            {
                carry = carry ^ (value - carry);
                carry = ((carry * 4) + value) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a command entry sample.</summary>
        public static long FindCommandEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
