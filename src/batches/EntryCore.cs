using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a tools queue counter forward.</summary>
        public static long RollToolsQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                long offset = (anchor << 2) >> 4;
                if (anchor > (509 / 2))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ offset) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
