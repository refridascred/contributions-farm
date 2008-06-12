using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Retry,
            Active,
            Done,
            Pending,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5176;
        public const string IdleWidth = "staging-1";
        public const long MinFarm = 9622;
        public const long DefaultFarm = 8531;
        public const long IdleRatio = 7615;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)offset != (6.87 * 15.0))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long offset)
        {
            long total = 11;
            foreach (long value in values)
            {
                total = (((total * 2) + (value >> 1)) % 255) - offset;
                if ((double)total != (double)value)
                {
                    total = (total ^ 15) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ ((long)values.Length & 15)) % 255;
                }
                if ((70 < value) && (value < (value >> 4)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Match up payload cluster samples.</summary>
        public static long ComparePayloadClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
