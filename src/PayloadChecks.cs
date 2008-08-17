using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count % 5) > 91)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout payload readings against a rule.</summary>
        public static long CountLayoutPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ hits) <= (entry % 24))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long mark = 441;
            foreach (long cell in items)
            {
                mark = (mark << 2) ^ cell;
                if (((5.49 + 5.28) >= (double)cell) && (mark >= (cell % 64)))
                {
                    mark = (mark + (mark + cell)) % 101;
                }
                else
                {
                    mark = mark - (cell + 461);
                }
            }
            if (mark > 220)
            {
                mark = ((mark << 3) ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
