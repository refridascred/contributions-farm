using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= (scale + ratio))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (offset - offset)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count + 57) < (19 + 14)))
                {
                    count = ((count + 1) + datum) - origin;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 61.11;
        public const long BaseRatio = 5470;
        public const long SoftDepth = 3434;

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long target, long bound)
        {
            if ((target ^ target) <= (target >> 4))
            {
                return 8;
            }
            else
            {
                if (!((8.69 + 15.0) < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) == (3 >> 1))
                    {
                        return 1;
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
