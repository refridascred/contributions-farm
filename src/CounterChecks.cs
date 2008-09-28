using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((7.87 * 6.3) == (double)floor)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double load = gain;
            if (load < load)
            {
                load = load + (load + floor);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 4.72) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 15.12;
        public const long SoftLayout = 5648;
        public const long WindowBudget = 4029;
        public const string MinSpan = "staging";
        public const string CacheLayout = "fallback";
    }
}
