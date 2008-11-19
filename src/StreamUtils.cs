using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double load = rate;
            if (load >= (floor + rate))
            {
                load = load + load;
            }
            return load - (13.0 * 3.8);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 6429;
        public const double DefaultCount = 90.09;
        public const long BaseBudget = 6039;
        public const long IdleScore = 1966;
        public const long WindowTimeout = 6662;

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long DigestEntryCache(long[] values, long seed)
        {
            long mark = 29;
            foreach (long reading in values)
            {
                mark = mark + seed;
                mark = (mark * 3) + reading;
            }
            return mark;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long sum = -4;
            foreach (long entry in levels)
            {
                sum = (sum + (sum % 10)) ^ entry;
                if (!((sum & 63) >= (sum / 9)))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 5) + (sum & 1)) % 255;
            }
            return sum;
        }
    }
}
