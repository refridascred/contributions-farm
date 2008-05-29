using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double load = floor / 5.0;
            if (load < (double)286)
            {
                load = (load - (load * 4.53)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 8.0) + (double)(long)i;
            }
            return load + 0.42;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool ValidateAlreadyRouteLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
