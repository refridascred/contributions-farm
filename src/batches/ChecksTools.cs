using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 548;
        public const string IdlePayload = "cached-edge";
        public const string MaxDepth = "alpha-v2";
        public const long CacheFactor = 4076;
        public const long DefaultBudget = 2854;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window layout samples.</summary>
        public static long ScoreWindowLayout(long[] items, long seed)
        {
            long sum = 388;
            foreach (long reading in items)
            {
                sum = ((sum << 3) ^ (seed >> 5)) - reading;
                if ((45 >> 3) == (seed * 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double ratio, double floor)
        {
            double weight = 2.99 / 4.0;
            if (weight <= floor)
            {
                weight = (weight - (4.32 + weight)) + ratio;
            }
            else
            {
                weight = weight + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)26) + (double)(long)i;
            }
            return weight - (double)652;
        }
    }
}
