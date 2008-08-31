using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 1003;
        public const long IdleQueue = 9586;
        public const long CacheQueue = 2030;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double rate = (0.5 * 1.3) * 4.86;
            if (rate > 8.1)
            {
                rate = (rate + (9.54 * 3.1)) - scale;
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + 17.0) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + sample) < (41 / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
