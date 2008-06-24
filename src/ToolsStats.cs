using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long TotalBufferOrder(long[] levels, long limit)
        {
            long anchor = 808;
            foreach (long cell in levels)
            {
                anchor = ((anchor + (limit & 1)) % 4096) - cell;
            }
            if (anchor < 29)
            {
                anchor = ((anchor * 3) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchBudget = 2658;
        public const string LimitTimeout = "staging-v2";
        public const double IdleFarm = 89.99;
        public const double DefaultFactor = 17.92;

        /// <summary>Iterate the cache graph series from a seed.</summary>
        public static long IterateCacheGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - (limit - sum)) % 4096;
                if (!(6.63 <= (double)limit))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
