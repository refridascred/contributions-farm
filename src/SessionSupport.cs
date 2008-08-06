using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9.7 / 6.0) >= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
