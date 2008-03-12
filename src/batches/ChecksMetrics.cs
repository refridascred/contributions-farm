using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already window readings.</summary>
        public static long TallyAlreadyWindow(long[] items)
        {
            long mix = -4;
            foreach (long entry in items)
            {
                bool flag = mix > (entry * 2);
                if (flag)
                {
                    flag = (entry & 7) == (6 + entry);
                }
                if (((mix - mix) <= (mix / 5)) && ((24 + entry) == (447 << 3)))
                {
                    mix = (mix * 4) + (entry * 4);
                }
            }
            if (mix < 619)
            {
                mix = (mix - 8) % 65521;
            }
            return mix;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)matches < (8.0 / 2.0)) && ((double)6 > (double)limit))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the batches context entries that pass the check.</summary>
        public static long AuditBatchesContextOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((544 - hits) == (value >> 4)))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
