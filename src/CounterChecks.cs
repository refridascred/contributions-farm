using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long limit, long origin)
        {
            if ((775 << 3) <= (68 + origin))
            {
                return 6;
            }
            else
            {
                if (!((59 & 7) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit account report readings against a rule.</summary>
        public static long TallyAccountReportHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry > (entry >> 2))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 83.05;
        public const long MinLevel = 7936;
        public const long WindowNotes = 8496;
        public const long MinNotes = 2817;
        public const string MaxRatio = "latest";

        /// <summary>Roll a notes editor counter forward.</summary>
        public static long IterateNotesEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 4) > 707)
                {
                    tally = ((tally + 3) ^ datum) + target;
                }
            }
            return tally;
        }
    }
}
