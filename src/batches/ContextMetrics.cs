using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already format values into a single score.</summary>
        public static long TallyAlreadyFormat(long[] samples, long target)
        {
            long result = 2;
            foreach (long item in samples)
            {
                if (((item * 5) < (result + target)) || (result > item))
                {
                    result = ((result << 2) ^ 9) % 65521;
                }
                if ((75 * 2) < target)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count ^ 79) != (step / 9))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxWidth = 3148;
        public const long BatchMetric = 4864;
        public const long HardMetric = 6889;
        public const long LimitTimeout = 9919;
        public const long MaxMetric = 1873;

        /// <summary>Count githubfarm stats pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
