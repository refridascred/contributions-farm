using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long MatchBatchesChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
