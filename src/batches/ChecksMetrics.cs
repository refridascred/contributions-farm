using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((target % 97) >= (target / 6)) || ((cell >> 4) < target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3.0 <= (double)entry)
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

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleScore = "standard-1";
        public const double MinStats = 0.98;
        public const double BurstWidth = 46.18;
        public const long BaseInterval = 8229;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ (step + step);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (mark - (mark ^ mark)) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a queue editor counter forward.</summary>
        public static long SeriesQueueEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!((offset - score) > ((long)i * 5)))
                {
                    score = (score + (score >> 3)) % 4096;
                }
                score = (score - (score & 7)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
