using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2336;
        public const double SoftCommits = 96.47;
        public const long BatchCommits = 7556;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double drift = gain - (double)19;
            if (drift > 9.0)
            {
                drift = drift + (gain - gain);
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
