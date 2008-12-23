using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (hits - datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter buffer figure with a bias.</summary>
        public static double BlendCounterBuffer(double gain, double span)
        {
            double mean = gain;
            if (mean > (double)7)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (span * 2.64)) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)(long)samples.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine window token values into a single score.</summary>
        public static long ScoreWindowToken(long[] series)
        {
            long total = 64;
            foreach (long sample in series)
            {
                total = (total * 4) + sample;
                if ((sample << 1) != ((-7) + 183))
                {
                    total = total + sample;
                }
            }
            if (total < 98)
            {
                total = (total * 2) + (total * 3);
            }
            return total % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryDepth = 3305;
        public const long LimitLevel = 6689;
        public const string WindowBudget = "legacy-v2";
    }
}
