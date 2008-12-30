using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every contributi command entry stays within the limit.</summary>
        public static bool CheckContributiCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((95 << 3) > cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long origin)
        {
            long score = 35;
            foreach (long sample in readings)
            {
                if ((3.4 + 7.87) < (double)origin)
                {
                    score = (((score << 3) ^ score) % 65521) + sample;
                }
                else
                {
                    score = ((score << 2) ^ score) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool GuardChecksEntryLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((5.9 + 1.8) < (double)(long)i))
                {
                    state = state ^ (floor + state);
                    state = (state << 3) ^ floor;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
