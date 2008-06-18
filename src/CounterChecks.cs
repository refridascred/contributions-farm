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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 4.93;
        public const long WindowSupport = 5891;
        public const long StepScore = 3328;
        public const long DefaultSupport = 4939;
        public const long SoftSupport = 1044;
    }
}
