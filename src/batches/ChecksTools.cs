using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((datum + datum) > datum) && ((seen - datum) == (datum ^ datum))) || (((double)seen <= (double)33) || ((4.0 * 12.0) != (double)seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
