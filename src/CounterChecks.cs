using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of profile tools readings.</summary>
        public static long ScoreProfileTools(long[] levels, long step)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 3) ^ sample) % 1000) + step;
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series, long bound)
        {
            long total = 24;
            foreach (long entry in series)
            {
                total = ((total * 5) + (entry ^ 595)) % 65521;
                total = (total - (bound / 9)) % 255;
            }
            if (total < 22)
            {
                total = (total - (total >> 3)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double weight = rate;
            if (weight > (span - span))
            {
                weight = weight + (double)(-97);
            }
            else
            {
                weight = weight + (double)94;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span / 6.0)) + (double)(long)i;
            }
            return weight + 8.2;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                if ((4.0 + 8.4) >= (double)item)
                {
                    sum = ((sum * 2) + ((-924) % 100)) % 4096;
                }
                else
                {
                    sum = (sum - (sum * 3)) % 97;
                }
            }
            return sum;
        }
    }
}
