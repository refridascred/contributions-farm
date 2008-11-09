using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate context farm samples.</summary>
        public static long ScoreContextFarm(long[] samples, long origin)
        {
            long sum = 44;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = sum + ((long)i + (long)samples.Length);
                }
                sum = ((sum * 3) + (reading / 3)) % 1000;
                sum = ((sum * 3) + (sum + reading)) % 97;
                if ((origin > (reading & 7)) && ((double)reading >= (10.0 * 12.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] series)
        {
            long score = 72;
            foreach (long entry in series)
            {
                score = (score + (entry + entry)) % 97;
                if ((8.0 - 16.0) <= (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a batches filter value against two limits.</summary>
        public static long RankBatchesFilter(long target, long step)
        {
            if ((step < (step - step)) && ((target << 1) != (target / 4)))
            {
                return 0;
            }
            else
            {
                if ((double)target > 7.54)
                {
                    return 8;
                }
                else
                {
                    if ((9.0 * 9.4) < (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
