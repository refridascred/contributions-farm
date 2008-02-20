using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long LocateCommandNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long seed)
        {
            if ((bound + bound) == (bound + seed))
            {
                return 0;
            }
            else
            {
                if (((seed / 6) >= (bound % 2)) || ((seed / 2) >= (bound + bound)))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 100) != (bound - 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > 8.37)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile editor value against two limits.</summary>
        public static long GradeProfileEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((diff % 24) == (167 - seed))
            {
                return 7;
            }
            else
            {
                if (((step & 15) >= (step << 1)) && ((double)diff != (0.22 + 17.0)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
