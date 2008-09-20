using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches + matches) >= (target >> 1)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((17.0 / 5.0) < (double)sample)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (0 & 255)) - datum;
            }
            if (mark > 6)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
