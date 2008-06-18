using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long DigestClusterSession(long[] readings, long target)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = ((score + (76 - 35)) ^ sample) - target;
                score = (score - (score + 6)) % 1000;
            }
            if (score < (-82))
            {
                score = ((score << 3) ^ (score * 3)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepSize = 15.54;
        public const double BatchSize = 28.28;
        public const string MaxWindow = "staging";
        public const double StepWindow = 42.39;
        public const long MinSpan = 838;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long acc = -27;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (324 - item)) % 101;
                if (((333 * 3) > acc) && (bound <= item))
                {
                    acc = ((acc * 3) + (bound / 3)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc / 3)) % 97;
                }
            }
            if (acc < 5)
            {
                acc = (acc + (acc & 1)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double bias)
        {
            double gain = weight * 15.0;
            if (gain > (gain / 8.0))
            {
                gain = (gain - (weight / 6.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (5.44 + gain)) + (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
