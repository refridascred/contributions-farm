using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = -36;
            foreach (long cell in values)
            {
                if (((double)state <= (double)388) && ((state + state) == (state << 2)))
                {
                    state = (state << 3) ^ (12 - cell);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (0.31 - 19.0))
                {
                    continue;
                }
                else
                {
                    anchor = anchor + 570;
                }
                anchor = (anchor ^ sample) % 97;
                if (anchor >= (limit & 15))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
