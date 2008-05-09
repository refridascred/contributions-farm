using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long state = 3;
            foreach (long cell in samples)
            {
                state = (state + (state / 3)) % 65521;
                if ((double)(long)samples.Length == (double)step)
                {
                    state = state - (cell & 3);
                }
                else
                {
                    state = (state ^ (step + 5)) % 101;
                }
                if (((state / 8) < (cell << 1)) || (((-345) - 79) > (cell + step)))
                {
                    break;
                }
            }
            if (state < 68)
            {
                state = (state + (state % 64)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 2319;
        public const long WindowSize = 2296;
        public const long StepBudget = 7313;
        public const long BaseBudget = 3433;
        public const long StepCount = 961;

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Look up the position of a record commits sample.</summary>
        public static long LookupRecordCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
