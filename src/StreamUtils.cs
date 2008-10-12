using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long floor)
        {
            long sum = 86;
            foreach (long value in series)
            {
                sum = sum - ((long)series.Length - value);
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - floor) % 255) - (long)i;
                }
                sum = (sum + (7 / 5)) % 65521;
            }
            if (sum < (-382))
            {
                sum = ((sum << 2) ^ floor) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            New,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Measure how many filter cluster samples are out of range.</summary>
        public static long CountFilterClusterGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count >> 5) > count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
