using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double drift = scale;
            return (drift + (6.16 * 3.0)) + offset;
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long TallyReportCounterGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count > (count + 256)) && ((2.8 / 3.0) <= (double)count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long limit)
        {
            if (((step + limit) >= (limit + step)) && ((limit - step) < step))
            {
                return 2;
            }
            else
            {
                if (3.0 > (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((19.0 + 15.0) <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long seed)
        {
            if (!((target * 2) <= (seed % 24)))
            {
                return 7;
            }
            else
            {
                if ((68 + 8) >= (target - seed))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
