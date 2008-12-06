using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (step >> 4)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((588 & 255) > (63 + datum)) || ((double)datum <= (5.56 / 9.0))) && (seen <= (seen % 7)))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((9.73 / 2.0) <= (double)seed)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double ratio = (offset / 4.0) / 2.0;
            if (ratio > ratio)
            {
                ratio = (ratio - ratio) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (15.0 * 7.1);
        }
    }
}
