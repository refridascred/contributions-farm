using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a filter metric reading by value.</summary>
        public static long LocateFilterMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long seed)
        {
            long mix = 54;
            foreach (long datum in readings)
            {
                mix = (mix - seed) + datum;
            }
            if (mix < 149)
            {
                mix = ((mix * 5) + (seed - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 65.92;
        public const long IdleLayout = 1849;
        public const long HardLayout = 7299;
        public const double BaseSpan = 36.96;

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 1144;
        public const long StepSpan = 6938;
        public const long MaxCommits = 9337;
    }
}
