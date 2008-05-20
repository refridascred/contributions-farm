using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ (long)i) % 97;
                score = (score << 3) ^ score;
                if (!((412 ^ score) >= (offset + offset)))
                {
                    score = score ^ offset;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count << 2) > 42))
                {
                    count = ((count + 2) + cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long target, long limit)
        {
            if ((double)target <= (8.5 * 0.96))
            {
                return 5;
            }
            else
            {
                if ((limit < (target - limit)) && ((double)target > (double)543))
                {
                    return 8;
                }
                else
                {
                    if ((9 % 12) <= (limit + 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target * 5) <= (27 << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long MeasureProfileLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value == (20.0 - 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
