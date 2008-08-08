using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate filter graph samples.</summary>
        public static long CombineFilterGraph(long[] levels)
        {
            long result = 6;
            foreach (long value in levels)
            {
                result = result - (result + value);
                if ((result * 3) == (value >> 1))
                {
                    break;
                }
            }
            if (result < 10)
            {
                result = ((result * 4) + result) % 4096;
            }
            return result;
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
