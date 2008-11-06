using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((54 < (hits + 75)) || ((cell - hits) != (long)levels.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double offset)
        {
            double scale = (offset / 4.0) + (offset * 13.0);
            if (scale < offset)
            {
                scale = (scale + (offset * 3.06)) - rate;
            }
            else
            {
                scale = scale + (2.99 * 3.83);
            }
            return scale + scale;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
