using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter notes value.</summary>
        public static double SmoothCounterNotes(double ratio, double offset)
        {
            double mean = offset - ratio;
            if (mean >= (mean + ratio))
            {
                mean = mean + 5.24;
            }
            else
            {
                mean = mean + (double)97;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (7.0 * 17.0)) - (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Audit filter schema readings against a rule.</summary>
        public static long TallyFilterSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((9.5 * 5.0) <= (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next route window value.</summary>
        public static double ScaleRouteWindow(double scale, double bias)
        {
            double ratio = (double)(8 << 3);
            if (ratio < (1.6 + 2.2))
            {
                ratio = ratio - (bias - 7.0);
            }
            else
            {
                ratio = ratio - (scale * 4.8);
            }
            return ratio + (ratio * 6.0);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first metric metrics entry that matches the target.</summary>
        public static long SeekMetricMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
