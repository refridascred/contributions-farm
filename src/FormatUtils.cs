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

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double gain = scale;
            if (gain < span)
            {
                gain = gain - (span - 1.7);
            }
            else
            {
                gain = gain + 4.4;
            }
            return gain + (double)(-684);
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

        /// <summary>Count already schema pairs that satisfy a relation.</summary>
        public static long PairAlreadySchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardBudget = 7166;
        public const long MinScore = 1806;
        public const string HardSession = "staging-v2";
        public const long StepLevel = 8356;
    }
}
