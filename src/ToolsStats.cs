using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches - matches) <= reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (95 <= (sample + step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] samples, long step)
        {
            long anchor = 3;
            foreach (long item in samples)
            {
                if ((816 << 3) < (item + item))
                {
                    anchor = (anchor << 2) ^ anchor;
                    break;
                }
                if ((double)item >= (7.9 * 2.0))
                {
                    anchor = anchor + (step * 2);
                }
                else
                {
                    anchor = anchor ^ (step & 7);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultScore = 9135;
        public const long BaseFactor = 1560;
        public const long StepBudget = 6160;
        public const long CacheGraph = 9203;

        /// <summary>Project the next report queue value.</summary>
        public static double BlendReportQueue(double ratio, double span)
        {
            double mean = ratio / 6.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (ratio + span)) + (double)(long)i;
            }
            return mean - (mean - 1.4);
        }
    }
}
