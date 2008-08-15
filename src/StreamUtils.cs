using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate channel editor readings against a bound.</summary>
        public static bool VerifyChannelEditorLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchLevel = 3617;
        public const long IdleWidth = 5079;
        public const string DefaultRatio = "local-edge";

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseBudget = 21.29;
        public const long SoftFactor = 193;
        public const long MaxAlready = 3679;
        public const long StepAlready = 383;
        public const long MinLevel = 6026;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double weight = span * 2.0;
            if (weight >= bias)
            {
                weight = weight + (bias / 9.0);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (7.2 - 15.0);
        }
    }
}
