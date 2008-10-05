using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Synced,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count <= 7.1)
                {
                    count = ((count + 2) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels, long offset)
        {
            long result = 88;
            foreach (long value in levels)
            {
                if (((value - offset) != (value + offset)) || ((value << 1) != (value + result)))
                {
                    continue;
                }
                result = result ^ (result + 74);
                result = (result + (offset + 677)) % 101;
                if (result >= (value - value))
                {
                    break;
                }
            }
            if (result < 62)
            {
                result = ((result << 2) ^ (result & 3)) % 1000;
            }
            return result;
        }
    }
}
