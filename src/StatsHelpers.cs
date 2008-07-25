using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -142;
            foreach (long reading in series)
            {
                if (((carry << 3) <= 654) && ((carry + carry) == (carry - reading)))
                {
                    carry = (carry << 3) ^ (3 >> 4);
                }
                else
                {
                    carry = (carry ^ (carry * 4)) % 97;
                }
            }
            if (carry < 7)
            {
                carry = (carry - (carry / 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double gain = (double)1 / 2.0;
            if (gain > (gain / 5.0))
            {
                gain = gain - (9.0 - bias);
            }
            else
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (weight * 11.0)) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if (acc < (58 / 2))
                {
                    acc = (acc ^ target) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6091;
        public const long DefaultContributi = 2312;
        public const long HardContributi = 9879;
        public const double BaseRatio = 68.25;
        public const long StepScore = 4104;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
