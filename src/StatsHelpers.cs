using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 5503;
        public const double BatchSpan = 48.48;
        public const long LimitToken = 484;

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double drift = offset + (gain / 5.0);
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the record metrics series from a seed.</summary>
        public static long StepRecordMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((16.0 * 7.0) <= (double)mix)
                {
                    mix = mix ^ (mix - bound);
                    mix = ((mix * 5) + (bound - bound)) % 65521;
                }
                mix = (mix << 2) ^ 83;
                if (((long)i + (long)i) == (mix + (long)i))
                {
                    break;
                }
                else
                {
                    mix = (mix * 5) + (bound / 4);
                    mix = (mix + (bound / 2)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
