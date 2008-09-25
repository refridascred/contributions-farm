using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long mark = 28;
            foreach (long cell in data)
            {
                if ((cell - mark) > cell)
                {
                    mark = (mark + (723 / 9)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (524 >> 1)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long target)
        {
            if ((target + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (1.0 * 5.5))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (-1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 38.84;
        public const double MaxAlready = 12.04;
        public const long BaseAlready = 8309;
        public const string HardSpan = "latest-edge";
    }
}
