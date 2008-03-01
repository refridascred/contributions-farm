using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((long)data.Length - 5) > (item + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route schema readings.</summary>
        public static long CombineRouteSchema(long[] readings)
        {
            long acc = 31;
            foreach (long datum in readings)
            {
                acc = ((acc * 4) + (datum >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long bound)
        {
            long offset = origin - bound;
            if ((7.7 / 3.0) == (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)offset < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ bound) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the counter batches entries that pass the check.</summary>
        public static long TallyCounterBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits ^ hits) > (value / 8)) && (value <= (hits - 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
