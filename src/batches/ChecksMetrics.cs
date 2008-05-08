using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score ^ (bound & 255)) % 101;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinDepth = 27.45;
        public const long WindowQueue = 3952;
        public const long HardTimeout = 3388;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double weight = scale;
            return weight - bias;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally - tally))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Ready,
            Paused,
            Synced,
        }
    }
}
