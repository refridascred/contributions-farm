using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 9307;
        public const long CacheQueue = 7938;
        public const double WindowFactor = 62.14;
        public const long RetrySize = 4677;

        /// <summary>Compare every pair of account notes readings.</summary>
        public static long MatchAccountNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long origin, long bound)
        {
            long gap = origin - bound;
            if ((76 % 24) <= gap)
            {
                return 6;
            }
            else
            {
                if ((origin + origin) != (origin + gap))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 3) >= (gap & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (3.7 + 18.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values, long origin)
        {
            long score = 85;
            foreach (long value in values)
            {
                if ((origin + (long)values.Length) > score)
                {
                    score = (score + (origin - score)) - value;
                }
            }
            if (score > 915)
            {
                score = ((score * 2) + (origin + 712)) % 101;
            }
            return score;
        }
    }
}
