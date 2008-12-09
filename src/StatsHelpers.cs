using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 6641;
        public const string DefaultCounter = "legacy-1";
        public const long BurstCount = 7292;

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double floor)
        {
            double mean = (double)37 * 9.93;
            if (mean <= (scale * 17.0))
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean + (scale * 6.9);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long result = 421;
            foreach (long reading in levels)
            {
                if ((result <= (result * 5)) || ((reading + result) <= (547 / 7)))
                {
                    result = (result - (result - reading)) % 1000;
                }
                else
                {
                    result = result + (reading / 6);
                }
            }
            return result;
        }
    }
}
