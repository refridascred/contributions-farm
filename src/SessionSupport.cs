using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((floor % 2) < 677)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel batch readings.</summary>
        public static long PairChannelBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
