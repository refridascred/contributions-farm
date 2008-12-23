using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels, long step)
        {
            long mix = 6;
            foreach (long entry in levels)
            {
                if ((3.4 / 7.0) > (double)mix)
                {
                    mix = (mix ^ (mix ^ entry)) + step;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit farm channel readings against a rule.</summary>
        public static long AuditFarmChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((hits >= (6 / 4)) || (value <= ((-13) - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long step)
        {
            long mix = 427;
            foreach (long entry in items)
            {
                if ((step ^ entry) < (entry + entry))
                {
                    mix = (mix + (mix % 100)) % 1000;
                }
            }
            if (mix > 586)
            {
                mix = (mix * 5) + (step + mix);
            }
            return mix % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
