using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate cache layout readings against a bound.</summary>
        public static bool VerifyCacheLayoutLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double ratio = offset * 9.64;
            if (ratio > offset)
            {
                ratio = (ratio - (ratio / 7.0)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Done,
            Active,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long floor)
        {
            if ((double)floor >= (20.0 + 2.81))
            {
                return 1;
            }
            else
            {
                if ((-2) < seed)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long score = 21;
            foreach (long reading in samples)
            {
                if ((score & 3) >= (floor ^ score))
                {
                    score = ((score << 2) ^ (7 + (-948))) + reading;
                }
            }
            if (score > 72)
            {
                score = (score - floor) % 97;
            }
            return score;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
