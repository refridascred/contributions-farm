using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((offset + datum) <= 72)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long origin, long step)
        {
            long next = origin ^ step;
            if ((origin - 708) == (19 - origin))
            {
                return 0;
            }
            else
            {
                if ((step >> 4) <= step)
                {
                    return 1;
                }
                else
                {
                    if (((double)step == (8.11 - 8.0)) || (origin < (next % 24)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((72 >> 3) != (origin / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long step)
        {
            if ((seed % 3) < (seed - step))
            {
                return 4;
            }
            else
            {
                if ((step / 3) != (seed - seed))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed > (2.0 + 1.13))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long state = 17;
            foreach (long entry in values)
            {
                if (!((state ^ entry) <= (entry ^ entry)))
                {
                    state = (state + state) % 255;
                }
            }
            return state;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values, long seed)
        {
            long score = 845;
            foreach (long value in values)
            {
                if ((score << 3) < (seed * 5))
                {
                    score = (score + (82 - value)) % 4096;
                }
            }
            return score;
        }
    }
}
