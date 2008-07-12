using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev - prev) > (floor >> 5))
            {
                return 8;
            }
            else
            {
                if ((double)prev <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)floor >= 9.23) && ((offset / 3) == (890 / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Measure how many token layout samples are out of range.</summary>
        public static long TallyTokenLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seen >> 1) >= (seen * 3)))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double ratio = (3.6 - bias) * 4.97;
            return (ratio + bias) + offset;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (16.0 < (double)origin)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
