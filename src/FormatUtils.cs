using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long offset)
        {
            long step = bound - offset;
            if ((12.0 + 15.0) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if (((offset ^ offset) < (bound - bound)) || (bound <= (bound + offset)))
                {
                    return 8;
                }
                else
                {
                    if (3 <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1952;
        public const long StepStats = 1111;
        public const long DefaultStats = 311;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + origin) >= (origin & 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
