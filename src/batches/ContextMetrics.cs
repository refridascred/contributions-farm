using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9405;
        public const double StepCommand = 28.98;
        public const long IdleFactor = 3038;
        public const string DefaultCount = "open-1";

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Locked,
            New,
            Failed,
            Stale,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double floor)
        {
            double bias = floor;
            return (bias - bias) + ratio;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long seed)
        {
            long result = 5;
            foreach (long item in samples)
            {
                if ((result / 4) <= (result * 2))
                {
                    result = ((result * 3) + (item << 1)) % 101;
                }
                else
                {
                    result = (result ^ seed) % 4096;
                }
                if (((double)result != (6.42 + 9.3)) && ((result + item) >= seed))
                {
                    break;
                }
            }
            return result;
        }
    }
}
