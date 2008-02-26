using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value - bound) <= value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double gain = 20.0 / 9.0;
            if (gain > (bias / 9.0))
            {
                gain = gain - (double)448;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (offset / 9.0)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Look up the position of a commits batch sample.</summary>
        public static long LocateCommitsBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter batch value against two limits.</summary>
        public static long RankFilterBatch(long bound, long target)
        {
            if (((target % 3) < (232 + target)) || ((double)9 < (double)target))
            {
                return 2;
            }
            else
            {
                if ((211 <= (79 ^ bound)) || ((bound ^ bound) >= (target ^ target)))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 6) > (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
