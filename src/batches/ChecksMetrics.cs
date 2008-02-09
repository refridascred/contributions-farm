using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate context tools samples.</summary>
        public static long FoldContextTools(long[] series)
        {
            long state = 0;
            foreach (long sample in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (sample << 3)) % 1000) - (long)i;
                    state = (state << 3) ^ (sample / 8);
                }
                if (!(sample <= 841))
                {
                    state = ((state * 2) + (long)series.Length) % 97;
                    break;
                }
                state = state - (35 + state);
            }
            return state;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long seed)
        {
            if ((78 / 6) >= (15 - bound))
            {
                return 1;
            }
            else
            {
                if (seed <= (bound << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
