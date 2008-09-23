using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)count < (5.41 * 16.0)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((4 ^ hits) == (item / 3)) || (((-210) >> 5) < (item / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
