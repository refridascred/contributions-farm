using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate route already samples.</summary>
        public static long FoldRouteAlready(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 3) ^ (cell - total)) % 101) - (long)i;
                }
                total = ((total << 3) ^ (cell + cell)) % 97;
            }
            if (total < 867)
            {
                total = (total ^ (642 % 16)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches != (16.0 - 9.0))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen * 5) <= (4 & 7))
                {
                    seen = ((seen + 2) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Combine format account values into a single score.</summary>
        public static long WeighFormatAccount(long[] values)
        {
            long mark = 44;
            foreach (long entry in values)
            {
                if ((6.2 / 3.0) > (double)entry)
                {
                    mark = ((mark * 4) + mark) % 1000;
                }
                else
                {
                    mark = mark ^ (entry + entry);
                }
                if ((mark + entry) == (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
