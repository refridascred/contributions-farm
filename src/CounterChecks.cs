using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value <= (value << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                anchor = anchor - (datum + datum);
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of payload profile readings.</summary>
        public static long MatchPayloadProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
