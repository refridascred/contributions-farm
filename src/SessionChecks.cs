using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((double)20 == (double)floor) && (mix <= (mix << 1)))
                {
                    mix = (mix + ((long)i - 848)) % 97;
                    mix = (mix * 4) + floor;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) != (hits & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (step < (score << 2))
                {
                    continue;
                }
                if ((step + (long)i) >= 9)
                {
                    score = score - (7 + 16);
                }
                score = score - (step + step);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
