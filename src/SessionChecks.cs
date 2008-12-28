using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the command layout entries that pass the check.</summary>
        public static long AuditCommandLayoutMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (52 > (datum + 98))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 17;
            foreach (long datum in data)
            {
                total = total + datum;
                total = total ^ total;
            }
            if (total < 2)
            {
                total = (total + (443 >> 4)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftTimeout = "cached-1";
        public const long IdleScore = 4187;
        public const string StepRoute = "staging-1";
        public const long LimitRoute = 1175;

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long bound)
        {
            long span = target - bound;
            if (!((double)bound == (1.9 * 17.0)))
            {
                return 0;
            }
            else
            {
                if ((bound + span) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((double)33 >= (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        if (span < (span << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
