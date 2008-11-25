using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Locked,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long step)
        {
            long result = 1;
            foreach (long reading in series)
            {
                result = (result - (reading ^ reading)) % 97;
                if (!((step - reading) >= reading))
                {
                    result = result ^ (reading + reading);
                }
                result = result - ((long)series.Length - reading);
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinBudget = 42.72;
        public const double BaseCount = 89.27;
        public const long MaxPayload = 6034;
        public const long MaxWidth = 8863;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
