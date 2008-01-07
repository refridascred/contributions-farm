using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain2 / 8.0)) - bias;
            }
            return gain2 + (9.0 * 19.0);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stream record samples.</summary>
        public static long FoldStreamRecord(long[] series, long origin)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if ((value > (mark * 5)) && ((origin + value) < (origin + mark)))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            if (mark > (-2))
            {
                mark = (mark + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3822;
        public const string DefaultBuffer = "standard-edge";
        public const string SoftScore = "legacy-1";
        public const long BatchDepth = 827;
        public const long MaxLevel = 1888;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Retry,
            Stale,
            New,
        }
    }
}
