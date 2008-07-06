using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up notes channel samples.</summary>
        public static long CompareNotesChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((step < datum) || (((5.9 / 2.0) == (double)hits) || ((hits + hits) != (step - (-268)))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long TallyStatsStreamOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) >= (seed / 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((double)seen <= (double)target) || (sample > (98 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
