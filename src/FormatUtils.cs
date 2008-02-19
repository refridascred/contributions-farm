using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long ScoreCommitsBuffer(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = (result << 3) ^ (result - value);
                result = result ^ (1 + (long)data.Length);
                result = (result + (value + (long)data.Length)) % 97;
            }
            if (result < 85)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long limit)
        {
            long prev = bound + limit;
            if ((prev + 280) >= limit)
            {
                return 8;
            }
            else
            {
                if (((3 / 2) < (limit >> 1)) && ((prev % 97) >= prev))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Active,
            Stale,
            Closed,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Done,
            Ready,
        }

        /// <summary>Validate graph context readings against a bound.</summary>
        public static bool GuardGraphContextBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
