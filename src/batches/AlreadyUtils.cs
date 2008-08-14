using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 3;
            foreach (long reading in data)
            {
                if (!(result < (reading + reading)))
                {
                    result = (result + (result - reading)) % 4096;
                }
                result = (result - (result % 12)) % 1000;
            }
            if (result < 4)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result % 65521;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Queued,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long floor)
        {
            long edge = target - floor;
            if ((floor / 5) > edge)
            {
                return 1;
            }
            else
            {
                if ((2.0 * 3.13) != (double)edge)
                {
                    return 4;
                }
                else
                {
                    if ((floor + edge) != (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - edge) != (floor + (-93))))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long floor)
        {
            long edge = bound - floor;
            if ((double)bound > (3.7 + 1.68))
            {
                return 0;
            }
            else
            {
                if (!((floor * 3) <= floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 8) <= (edge + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + floor) == (bound & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
