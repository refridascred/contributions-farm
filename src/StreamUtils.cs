using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((step + 43) <= step)
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Check that every tools format entry stays within the limit.</summary>
        public static bool VerifyToolsFormatRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + limit) % 97;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings)
        {
            long carry = 184;
            foreach (long item in readings)
            {
                if (!((carry & 63) != (carry >> 4)))
                {
                    carry = carry - (item >> 2);
                }
            }
            return carry % 4096;
        }
    }
}
