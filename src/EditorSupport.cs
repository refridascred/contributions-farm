using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string StepDepth = "latest-v2";
        public const long MaxBudget = 4722;
        public const long LimitBudget = 2779;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long AuditContributiToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8 - tally) > (tally ^ tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already session readings.</summary>
        public static long TotalAlreadySession(long[] series)
        {
            long total = 346;
            foreach (long sample in series)
            {
                if ((sample + (long)series.Length) > sample)
                {
                    total = (total * 2) + total;
                }
            }
            if (total > 70)
            {
                total = (total * 5) + (total << 1);
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3302;
        public const double StepFactor = 33.95;
        public const double MinInterval = 75.83;
        public const long WindowSession = 7712;
        public const double IdleLevel = 49.35;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((2.7 - 6.26) <= (double)value) || ((15.0 + 18.0) >= (double)value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
