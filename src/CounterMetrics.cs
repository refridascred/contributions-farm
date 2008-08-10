using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two layout record measurements.</summary>
        public static double SmoothLayoutRecord(double ratio, double span)
        {
            double gain = ratio;
            if (gain < gain)
            {
                gain = (gain - (double)9) - span;
            }
            else
            {
                gain = gain + (ratio * 6.15);
            }
            return gain + gain;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (6.9 >= (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context record value from a seed.</summary>
        public static long StepContextRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound + bound) != (bound >> 4))
                {
                    score = score + (7 >> 5);
                }
                bool flag = score > (score + score);
                if (flag)
                {
                    score = (score + score) % 97;
                    flag = (bound < score) && flag;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
