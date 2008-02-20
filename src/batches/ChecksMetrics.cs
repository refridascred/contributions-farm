using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a tools contributi reading by value.</summary>
        public static long LookupToolsContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(floor >= (3 + reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long TotalToolsQueue(long[] data, long step)
        {
            long sum = 6;
            foreach (long entry in data)
            {
                sum = sum - (entry + sum);
                sum = (sum - (step + sum)) % 4096;
                sum = sum ^ (entry - 935);
            }
            if (sum < 197)
            {
                sum = ((sum << 3) ^ (3 ^ 86)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long result = 92;
            foreach (long cell in samples)
            {
                if ((long)samples.Length > 4)
                {
                    result = ((result * 3) + (cell + cell)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Pending,
            Dropped,
            Closed,
        }
    }
}
