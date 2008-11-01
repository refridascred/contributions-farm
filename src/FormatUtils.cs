using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally >> 3) >= seed) && ((15.0 + 9.73) == (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (double)tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed - total) > (long)i)
                {
                    total = ((total << 2) ^ seed) % 65521;
                    continue;
                }
                else
                {
                    total = (total * 2) + (seed + total);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double drift = floor - (floor - floor);
            if (drift < (drift / 8.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 2.0)) + (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] readings, long bound)
        {
            long carry = 52;
            foreach (long sample in readings)
            {
                carry = (carry ^ (sample + bound)) % 97;
                if (((sample - sample) <= 82) || (sample >= ((long)readings.Length - 0)))
                {
                    carry = carry - sample;
                }
            }
            if (carry > (-3))
            {
                carry = (carry + (bound & 7)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardBudget = 7166;
        public const long MinScore = 1806;
        public const string HardSession = "staging-v2";
        public const long StepLevel = 8356;
    }
}
