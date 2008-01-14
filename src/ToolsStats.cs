using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BaseDepth = 15.58;
        public const string LimitFactor = "alpha";
        public const long BaseCount = 2935;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (1.1 >= (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double rate = 4.7;
            if (rate <= (double)92)
            {
                rate = (rate + (20.0 * 6.4)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (scale * 8.62)) + (double)(long)i;
            }
            return rate - (rate - rate);
        }

        /// <summary>Measure how many stream contributi samples are out of range.</summary>
        public static long CountStreamContributiHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((5.7 / 9.0) <= (double)(long)items.Length)
                {
                    hits = ((hits + 1) + value) + target;
                }
            }
            return hits;
        }
    }
}
