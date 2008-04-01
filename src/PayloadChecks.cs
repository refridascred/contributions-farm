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

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double drift = bias;
            if (drift >= 3.0)
            {
                drift = drift - (gain / 2.0);
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + gain) - (double)(long)i;
            }
            return drift - 7.1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Closed,
            Locked,
            Failed,
        }
    }
}
