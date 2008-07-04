using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate filter metric readings against a bound.</summary>
        public static bool VerifyFilterMetricRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a entry command reading.</summary>
        public static double SmoothEntryCommand(double gain, double offset)
        {
            double gain2 = (double)(70 - 1);
            if (gain2 < (double)26)
            {
                gain2 = ((gain2 + 6.89) - gain) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + (double)(-39)) - (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((double)delta == (14.0 + 9.0))
            {
                return 6;
            }
            else
            {
                if (!((double)seed != (double)delta))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin > (9.96 + 9.81)) || ((3.58 + 4.36) == (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
