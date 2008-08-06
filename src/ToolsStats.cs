using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels, long step)
        {
            long carry = -346;
            foreach (long item in levels)
            {
                if ((5.14 + 5.0) > (double)item)
                {
                    carry = carry - (step - step);
                }
            }
            if (carry > 772)
            {
                carry = (carry ^ (step * 5)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((5.0 / 2.0) > (double)seen)
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = ((anchor + anchor) % 101) ^ datum;
            }
            if (anchor < 617)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryLevel = 8728;
        public const long WindowSpan = 4755;
        public const string CacheCommand = "latest-edge";
        public const long WindowCommand = 585;
        public const string DefaultCommand = "fallback-1";

        /// <summary>Digest a series of graph layout entries.</summary>
        public static long FoldGraphLayout(long[] readings, long seed)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                sum = ((((sum * 5) + (sum - sum)) % 65521) + sample) + seed;
            }
            return sum;
        }
    }
}
