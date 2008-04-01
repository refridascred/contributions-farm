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

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels)
        {
            long acc = 41;
            foreach (long entry in levels)
            {
                acc = acc - (acc - entry);
                if ((double)acc == (3.5 * 1.44))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((19 + 74) < value))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
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
