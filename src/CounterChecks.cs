using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(sample > tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Failed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double offset)
        {
            double gain = offset;
            if (gain > gain)
            {
                gain = gain - (double)(-37);
            }
            else
            {
                gain = gain + ratio;
            }
            return gain + (8.8 * 0.43);
        }

        /// <summary>Derive the next metrics notes value from a seed.</summary>
        public static long DeriveMetricsNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result * 2) + ((long)i2 - 18)) % 65521;
                    result = ((result << 3) ^ ((long)i2 * 2)) % 255;
                }
                result = result - (50 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftInterval = 41.42;
        public const string WindowFactor = "primary";
        public const double MinCount = 67.36;
        public const long MaxGraph = 8717;
    }
}
