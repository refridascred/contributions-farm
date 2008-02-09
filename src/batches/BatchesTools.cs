using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long AuditReportMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 127) >= (matches * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool CheckReportBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm report entries.</summary>
        public static long CombineGithubfarmReport(long[] readings)
        {
            long carry = 93;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) < (cell & 3))
                {
                    carry = (carry - carry) % 255;
                }
            }
            if (carry < 872)
            {
                carry = carry ^ 9;
            }
            return carry % 1000;
        }
    }
}
