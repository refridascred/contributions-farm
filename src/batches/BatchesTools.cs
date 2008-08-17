using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + 0) == (seen % 97))
                {
                    seen = ((seen + 3) + sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + 91) <= (entry - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
