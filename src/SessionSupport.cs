using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long reading in readings)
            {
                if (!(1.1 >= 1.9))
                {
                    acc = (acc + (offset + (long)readings.Length)) + reading;
                }
            }
            if (acc < 898)
            {
                acc = ((acc << 2) ^ (offset + 476)) % 101;
            }
            return acc % 65521;
        }
    }
}
