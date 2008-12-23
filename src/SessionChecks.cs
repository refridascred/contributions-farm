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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long origin2)
        {
            long delta = origin - origin2;
            if ((origin & 31) >= (delta - origin2))
            {
                return 5;
            }
            else
            {
                if ((origin + origin) > origin)
                {
                    return 0;
                }
                else
                {
                    if (origin > (73 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta - origin) != (origin * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
