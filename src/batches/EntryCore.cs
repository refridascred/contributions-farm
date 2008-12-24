using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a profile metrics reading.</summary>
        public static double ProjectProfileMetrics(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < (9.1 + 9.97))
            {
                rate2 = (rate2 + rate2) + floor;
            }
            return rate2 + (rate + rate2);
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result % 60);
                if ((result - result) <= target)
                {
                    result = ((result * 3) + (target % 3)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result + result);
                    result = ((result << 3) ^ (result * 2)) % 65521;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a batches contributi figure with a bias.</summary>
        public static double ProjectBatchesContributi(double rate, double span)
        {
            double gain = (rate / 6.0) * 17.0;
            if (gain <= rate)
            {
                gain = gain + span;
            }
            return gain - (double)922;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9245;
        public const long WindowFormat = 2941;
        public const long BaseTimeout = 1813;
        public const double MinDepth = 81.61;
        public const long DefaultFormat = 1130;
    }
}
