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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long floor)
        {
            long score = 434;
            foreach (long cell in values)
            {
                if ((9.5 - 1.5) > (16.0 * 4.7))
                {
                    score = (score + (score + cell)) % 97;
                }
                if (((score << 3) > (15 + cell)) && (score < cell))
                {
                    score = (score - score) % 4096;
                }
                if ((floor << 2) == (cell + floor))
                {
                    score = (score ^ floor) % 65521;
                }
                if ((score * 4) != (cell + floor))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double drift = (double)(56 >> 3);
            if (drift < scale)
            {
                drift = (drift - (double)13) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)58) + (double)(long)i;
            }
            return drift + (double)4;
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
