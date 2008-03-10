using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if ((floor2 + cur) <= (floor2 >> 3))
            {
                return 1;
            }
            else
            {
                if (((floor + cur) < (cur * 3)) && ((21 + floor2) >= cur))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) == (cur + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((cur >> 2) > floor2) && ((18.0 - 3.3) < (double)floor2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long state = 79;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 * 5.0))
                {
                    state = ((state * 3) + (entry - (long)levels.Length)) % 97;
                }
            }
            if (state > 49)
            {
                state = ((state << 3) ^ (state % 97)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Validate stream context readings against a bound.</summary>
        public static bool ValidateStreamContextBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((hits ^ hits) == (value - hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long origin2)
        {
            if ((origin / 6) > origin)
            {
                return 1;
            }
            else
            {
                if ((origin >= (origin % 7)) || ((798 - origin2) > origin2))
                {
                    return 4;
                }
                else
                {
                    if ((origin < 384) || ((origin + origin) >= (origin2 - 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
