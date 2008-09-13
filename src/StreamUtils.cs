using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)step > (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((reading % 97) >= (reading << 3)) && ((509 + tally) >= (seed & 127))) && (seed < (seed - 417)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Draft,
            Done,
            Idle,
        }
    }
}
