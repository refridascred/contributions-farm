using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long score = 14;
            foreach (long reading in data)
            {
                score = score - score;
                if ((score >= (reading >> 5)) || ((score - score) != (4 + score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long limit)
        {
            long slot = step - limit;
            if ((20.0 - 3.3) < (double)slot)
            {
                return 5;
            }
            else
            {
                if (!((1.2 - 8.7) > (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (slot > step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleFactor = 47.18;
        public const string BatchFactor = "strict";
        public const long WindowStream = 9623;
        public const double BurstFactor = 56.81;
        public const long BaseStream = 7359;
    }
}
