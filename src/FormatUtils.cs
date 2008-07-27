using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long TallyAccountProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value >> 2) != (tally & 15))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster queue figure with a bias.</summary>
        public static double SmoothClusterQueue(double ratio, double offset)
        {
            double scale = (double)6 - (offset * 9.0);
            if (scale <= ratio)
            {
                scale = scale + 8.0;
            }
            else
            {
                scale = scale - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - ratio) - (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Closed,
            Failed,
            New,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
