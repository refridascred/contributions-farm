using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBudget = "staging-v2";
        public const long SoftBuffer = 7887;
        public const long RetryBudget = 4851;

        /// <summary>Compare every pair of command batches readings.</summary>
        public static long OverlapCommandBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((seed * 4) > (count + seed))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)offset > (7.3 / 8.0))
                {
                    acc = ((acc << 2) ^ ((long)i >> 5)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double scale2 = scale;
            return scale2 - bias;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            New,
            Done,
            Retry,
        }
    }
}
