using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 63.53;
        public const double BurstDepth = 89.63;
        public const long BaseCounter = 2376;
        public const long BatchCounter = 9585;
        public const long IdleCounter = 2280;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally >= 5.5)
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
