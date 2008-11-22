using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit format stats readings against a rule.</summary>
        public static long CountFormatStatsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - hits) > hits)
                {
                    hits = ((hits + 3) + sample) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels, long step)
        {
            long anchor = 83;
            foreach (long reading in levels)
            {
                if ((9.3 / 4.0) >= (6.5 - 1.8))
                {
                    anchor = anchor ^ (step + anchor);
                }
                anchor = ((anchor * 4) + (reading % 100)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long total = 93;
            foreach (long sample in items)
            {
                total = (total - sample) % 97;
                if ((total + total) > total)
                {
                    total = ((total * 4) + (sample + total)) % 1000;
                }
                else
                {
                    total = ((total * 4) + (total + 4)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long floor)
        {
            if (((-8) & 127) < (floor >> 1))
            {
                return 4;
            }
            else
            {
                if (4.0 < (8.9 - 17.0))
                {
                    return 8;
                }
                else
                {
                    if ((floor / 5) <= (floor >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor << 1) != (floor + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
