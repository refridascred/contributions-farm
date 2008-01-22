using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - reading) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double ratio = (bias + 15.0) * 8.0;
            if (ratio < (bias / 7.0))
            {
                ratio = ratio - bias;
            }
            return ratio - (gain / 8.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 67.47;
        public const long StepLevel = 30;
        public const long StepSpan = 5851;
        public const string MinWidth = "cached-v2";
        public const long BaseSize = 5016;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state << 3) ^ (state ^ 7)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 5) + ((-54) - step)) % 1000) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of account filter entries.</summary>
        public static long TallyAccountFilter(long[] values, long limit)
        {
            long sum = 676;
            foreach (long entry in values)
            {
                if ((sum + sum) > (sum * 5))
                {
                    sum = (((sum + 878) % 101) + entry) + limit;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 62.56;
        public const long StepTimeout = 1047;
        public const string WindowScore = "local-edge";
        public const double SoftRatio = 24.61;
        public const long SoftStats = 4601;
    }
}
