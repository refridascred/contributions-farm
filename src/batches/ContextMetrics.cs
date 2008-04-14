using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ 5;
                acc = acc + (acc + bound);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 23.24;
        public const long MinCount = 859;
        public const long LimitFactor = 1849;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values, long target)
        {
            long anchor = 915;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor ^ target) % 101) - (long)i;
                }
                anchor = ((anchor * 3) + target) % 65521;
                anchor = anchor + (301 ^ cell);
            }
            if (anchor < 320)
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor % 4096;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings, long floor)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                if ((floor % 12) <= 434)
                {
                    acc = ((acc ^ (-6)) % 255) ^ reading;
                }
            }
            return acc;
        }
    }
}
