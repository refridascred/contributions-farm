using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4336;
        public const long HardContributi = 4907;
        public const long BatchWidth = 2516;
        public const long WindowSpan = 6377;
        public const string DefaultContributi = "standard-edge";

        /// <summary>Scale a layout format figure with a bias.</summary>
        public static double BlendLayoutFormat(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > ratio)
            {
                drift = (drift + drift) - floor;
            }
            else
            {
                drift = drift - (8.0 / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (double)809;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
