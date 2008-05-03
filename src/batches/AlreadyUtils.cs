using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token session readings against a rule.</summary>
        public static long MeasureTokenSessionMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((8.0 / 7.0) <= (double)reading) || ((310 < (floor % 8)) && ((floor - floor) <= (matches * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry queue value against two limits.</summary>
        public static long RankEntryQueue(long floor, long bound)
        {
            long prev = floor + bound;
            if (floor >= 61)
            {
                return 7;
            }
            else
            {
                if ((double)bound > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (bound <= (floor + prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((prev << 2) >= (floor % 10)) && ((floor + bound) != (bound + bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
