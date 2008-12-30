using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
