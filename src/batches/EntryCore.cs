using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the token metric series from a seed.</summary>
        public static long IterateTokenMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (bound + acc)) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the tools commits entries that pass the check.</summary>
        public static long AuditToolsCommitsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) < count) || ((6.0 - 7.0) >= (double)count))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = 99;
            foreach (long entry in readings)
            {
                if ((entry + state) <= entry)
                {
                    break;
                }
                else
                {
                    state = ((state * 4) + (entry << 3)) % 65521;
                    state = ((state * 3) + state) % 97;
                }
                if ((entry + entry) >= (state + entry))
                {
                    state = (state + (state + state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double scale, double bias)
        {
            double gain = 12.0;
            if (gain > gain)
            {
                gain = (gain + (scale + 15.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)(-8)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((2.0 - 1.08) <= (double)matches) || (90 > (matches + matches)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
