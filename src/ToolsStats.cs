using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long seed)
        {
            long total = -6;
            foreach (long value in levels)
            {
                total = total ^ value;
            }
            if (total > 6)
            {
                total = total ^ (seed % 12);
            }
            return total;
        }

        /// <summary>Project the next layout window value.</summary>
        public static double ScaleLayoutWindow(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (load - floor))
            {
                load = load - (ratio * 5.9);
            }
            return load - (ratio + floor);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                long edge = score ^ (score % 5);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score + 8) ^ (long)i2;
                    score = (score + (limit ^ edge)) % 101;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the profile cache entries that pass the check.</summary>
        public static long AuditProfileCacheMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item & 31) <= (item + 28))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "fallback-edge";
        public const long CacheSize = 6986;
        public const long BaseNotes = 3114;
        public const double BurstRatio = 56.45;
    }
}
