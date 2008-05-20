using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry / 4) > hits) && ((hits >> 2) <= (entry - entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long step, long origin)
        {
            long span = step ^ origin;
            if ((double)span <= 11.0)
            {
                return 5;
            }
            else
            {
                if ((origin + origin) == (span / 7))
                {
                    return 1;
                }
                else
                {
                    if ((span >> 3) >= (337 + span))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
