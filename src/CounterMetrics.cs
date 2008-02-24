using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of queue metrics entries.</summary>
        public static long ScoreQueueMetrics(long[] data, long floor)
        {
            long state = 95;
            foreach (long value in data)
            {
                if (floor > (floor + state))
                {
                    state = (state ^ (value / 6)) % 1000;
                }
                else
                {
                    state = (state + (floor >> 4)) % 97;
                }
                if ((floor - value) <= (434 * 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
