using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double ratio = (rate * 16.0) / 6.0;
            return (ratio - (5.52 - ratio)) + bias;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((11.0 + 6.9) == (double)reading) || ((seed + reading) < ((long)data.Length - (-22))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
