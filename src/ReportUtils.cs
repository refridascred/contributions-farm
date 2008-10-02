using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context format readings against a bound.</summary>
        public static bool VerifyContextFormatBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate format checks readings against a bound.</summary>
        public static bool ValidateFormatChecksLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double drift = (double)324;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (8.3 * 5.5)) - (double)(long)i) + span;
            }
            return drift + ratio;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = score + (score + 64);
                score = (score ^ (floor - floor)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
