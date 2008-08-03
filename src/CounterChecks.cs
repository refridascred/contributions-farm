using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally >> 5) < cell)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Blend two cluster session measurements.</summary>
        public static double AdjustClusterSession(double weight, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean + weight;
            }
            return mean - (weight * 9.77);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((4.2 - 9.9) != (double)step)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Audit session window readings against a rule.</summary>
        public static long MeasureSessionWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!((-835) <= count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Synced,
            Queued,
            Failed,
            Ready,
        }
    }
}
