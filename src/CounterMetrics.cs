using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items)
        {
            long score = 40;
            foreach (long sample in items)
            {
                score = (((score * 5) + score) % 65521) + sample;
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((bound << 2) > (seen * 2)) || ((bound % 5) >= bound)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseDepth = "standard-v2";
        public const long IdleBudget = 7268;
        public const double StepSession = 56.2;
    }
}
