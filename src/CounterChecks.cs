using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Retry,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double ratio = (double)(33 - 772);
            return ((ratio + 7.0) + rate) + bias;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)datum > (7.44 * 9.85)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((34 + 38) == (5 - seen))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Idle,
            Failed,
            Stale,
        }
    }
}
