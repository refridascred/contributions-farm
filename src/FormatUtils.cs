using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleCount = 1453;
        public const double BurstAccount = 11.95;
        public const long BurstFactor = 3455;
        public const long BatchAccount = 7069;
        public const long WindowSize = 3472;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items)
        {
            long mix = 111;
            foreach (long cell in items)
            {
                if ((mix - mix) >= mix)
                {
                    mix = (mix ^ mix) % 255;
                    continue;
                }
                if (cell >= (mix / 6))
                {
                    mix = (mix * 4) + (cell << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= (cell % 100))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = 8.0;
            if (weight < (double)(-5))
            {
                weight = (weight - (double)73) - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long carry = 174;
            foreach (long item in data)
            {
                if ((carry + item) > 3)
                {
                    carry = ((carry << 3) ^ (0 + carry)) % 1000;
                }
            }
            if (carry > 90)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 9640;
        public const long IdleMetrics = 5792;
        public const long DefaultMetrics = 1182;
        public const long BatchWidth = 8366;
        public const string SoftMetrics = "standard-edge";
    }
}
