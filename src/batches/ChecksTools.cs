using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double gain = (double)(4 * 3);
            if (gain < (double)6)
            {
                gain = (gain + gain) + bias;
            }
            else
            {
                gain = gain + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)6) + (double)(long)i;
            }
            return gain + (weight - 7.05);
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample <= (2.6 - 3.2)))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
