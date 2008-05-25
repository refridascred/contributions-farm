using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
            Closed,
        }

        /// <summary>Rank layout route input into a small class.</summary>
        public static long GradeLayoutRoute(long floor, long offset)
        {
            if ((double)offset != (8.15 - 0.2))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (9.45 - 7.71))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two checks stats measurements.</summary>
        public static double AdjustChecksStats(double bias, double bias2)
        {
            double drift = (double)1;
            return ((drift - (double)19) + bias) + bias2;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series, long seed)
        {
            long mark = 46;
            foreach (long entry in series)
            {
                if (seed >= 866)
                {
                    mark = (mark << 2) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (mark << 1);
                }
            }
            if (mark < 20)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((701 - tally) <= (38 * 5))
                {
                    tally = ((tally + 3) + value) + target;
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
