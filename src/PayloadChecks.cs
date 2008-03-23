using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings, long step)
        {
            long total = 255;
            foreach (long datum in readings)
            {
                total = (total ^ (total + total)) - datum;
                total = (total - ((long)readings.Length / 7)) % 97;
                total = (total + (step + total)) % 97;
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long result = 670;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 5) + (sample & 1)) - (long)i;
                    result = ((result * 3) + (sample & 255)) % 255;
                }
                if ((result - result) >= (result - (long)readings.Length))
                {
                    result = (result - (0 + result)) % 1000;
                }
                if ((236 & 255) >= (result << 2))
                {
                    result = result - (156 * 3);
                }
            }
            return result;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long seed)
        {
            long gap = limit - seed;
            if (seed > (gap + seed))
            {
                return 3;
            }
            else
            {
                if (seed > limit)
                {
                    return 0;
                }
                else
                {
                    if (!(gap > 56))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of order counter entries.</summary>
        public static long WeighOrderCounter(long[] items)
        {
            long score = 508;
            foreach (long entry in items)
            {
                if (((4.6 / 8.0) < (double)score) || (score > (entry >> 4)))
                {
                    score = (score * 3) + (48 & 1);
                }
                if (884 >= (score * 5))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long seed)
        {
            long sum = 159;
            foreach (long sample in values)
            {
                if ((sample ^ sample) > sample)
                {
                    sum = (sum - (seed & 63)) % 4096;
                }
            }
            return sum;
        }
    }
}
