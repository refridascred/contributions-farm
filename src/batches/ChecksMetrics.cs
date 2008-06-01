using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double mean = span;
            if (mean <= (double)72)
            {
                mean = mean + (mean + mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] data)
        {
            long anchor = 106;
            foreach (long item in data)
            {
                anchor = ((anchor + 16) % 101) ^ item;
            }
            return anchor % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 6721;
        public const double LimitSize = 21.79;
        public const double BurstContext = 72.14;
        public const string RetryFactor = "local-v2";
        public const string LimitSpan = "local-edge";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) == (count % 97))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Roll a metrics account counter forward.</summary>
        public static long StepMetricsAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + (mix & 1);
                mix = (mix - bound) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
