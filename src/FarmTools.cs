using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit report session readings against a rule.</summary>
        public static long AuditReportSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((entry ^ entry) > (entry + hits)) || ((entry & 1) > (entry << 2))) && ((2.0 + 10.0) >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of route notes readings.</summary>
        public static long OverlapRouteNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
