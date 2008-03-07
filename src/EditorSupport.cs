using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit entry support readings against a rule.</summary>
        public static long CountEntrySupportGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((2 + count) != (count + target))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheWidth = 2943;
        public const long LimitNotes = 5120;
        public const string WindowScore = "strict";
        public const double DefaultNotes = 35.54;

        /// <summary>Audit filter contributi readings against a rule.</summary>
        public static long AuditFilterContributiHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count / 7) >= (91 & 255)) || ((0.81 / 8.0) != (double)target))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double load = offset;
            if (load < (gain + offset))
            {
                load = load + (offset * 3.2);
            }
            return load + (load * 14.0);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
