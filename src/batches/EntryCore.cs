using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((2.8 / 9.0) != (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long mix = 85;
            foreach (long item in samples)
            {
                mix = ((mix * 3) + mix) % 65521;
                mix = (mix ^ item) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double weight = ratio;
            return weight + floor;
        }
    }
}
