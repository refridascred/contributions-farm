using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) <= (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin - origin) > (long)i)
                {
                    state = (state ^ ((long)i * 3)) % 97;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples)
        {
            long result = 93;
            foreach (long cell in samples)
            {
                if ((15.0 - 5.0) >= (double)cell)
                {
                    result = result - (88 >> 4);
                }
            }
            if (result < 61)
            {
                result = result + (399 + result);
            }
            return result;
        }

        /// <summary>Grade a schema payload value against two limits.</summary>
        public static long GradeSchemaPayload(long offset, long limit)
        {
            long lane = offset + limit;
            if ((20.0 / 4.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == ((-122) + lane))
                {
                    return 6;
                }
                else
                {
                    if ((offset / 7) < (29 / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Idle,
            Dropped,
            Done,
        }
    }
}
