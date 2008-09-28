using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Dropped,
            Retry,
            Active,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double mean = (3.29 + span) / 8.0;
            if (mean < (mean / 7.0))
            {
                mean = mean + (bias - span);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell % 7) <= cell) && ((15.0 + 5.3) == (double)cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((9.8 + 1.27) >= (double)cell)
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Draft,
            Synced,
            Ready,
        }
    }
}
