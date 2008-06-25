using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a metric entry counter forward.</summary>
        public static long IterateMetricEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepTimeout = "legacy-v2";
        public const double LimitInterval = 28.48;
        public const long LimitLevel = 3763;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (seed > (tally + 8))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 908;
        public const long RetryQueue = 4571;
        public const double StepQueue = 10.89;
        public const double CacheQueue = 56.54;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias + weight)) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
