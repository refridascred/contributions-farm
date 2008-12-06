using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Blend two graph account measurements.</summary>
        public static double ProjectGraphAccount(double weight, double span)
        {
            double weight2 = (double)9 + (double)114;
            if (weight2 > (double)719)
            {
                weight2 = weight2 - (double)75;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + (span * 3.02);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry >= (65 + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
