using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long AuditChannelBufferGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (0 <= (704 + sample))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result + floor) - (long)i2;
                }
                result = (result - floor) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 160;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ reading) % 255;
                if ((reading - reading) >= (state + reading))
                {
                    state = state - 907;
                }
                else
                {
                    state = (state - (state << 2)) % 4096;
                }
                if ((reading % 12) != (state + reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
