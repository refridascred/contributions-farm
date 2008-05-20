using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 8388;
        public const long BatchStats = 7101;
        public const string MinScore = "stable";
        public const string DefaultScore = "fallback-edge";

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long TallyNotesFarmOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((count ^ sample) < sample) || ((sample % 8) > (sample + count)))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                if (!(value < (value + value)))
                {
                    acc = acc ^ (value / 6);
                }
                else
                {
                    acc = (acc ^ (257 + value)) % 255;
                }
            }
            if (acc < 377)
            {
                acc = (acc - (acc % 64)) % 255;
            }
            return acc % 97;
        }
    }
}
