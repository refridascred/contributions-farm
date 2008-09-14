using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine format window values into a single score.</summary>
        public static long WeighFormatWindow(long[] values, long step)
        {
            long sum = 801;
            foreach (long value in values)
            {
                if (step >= (value * 3))
                {
                    sum = sum ^ (sum - step);
                }
            }
            if (sum < 863)
            {
                sum = (sum ^ (sum + 19)) % 4096;
            }
            return sum;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] values, long offset)
        {
            long carry = 35;
            foreach (long value in values)
            {
                carry = (((carry * 2) + 5) % 97) - value;
            }
            if (carry < 95)
            {
                carry = (carry + offset) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a entry metrics sample.</summary>
        public static long FindEntryMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
