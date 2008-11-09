using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Active,
            New,
            Dropped,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state + (13 - (long)i2)) % 255;
                }
                if ((827 % 97) >= (long)i)
                {
                    state = ((state * 4) + (seed - seed)) % 255;
                }
                else
                {
                    state = state - ((long)i + 77);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long bound, long target)
        {
            if ((double)bound <= (18.0 + 13.0))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) == (target - 5))
                {
                    return 5;
                }
                else
                {
                    if ((3.75 + 7.3) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.0 > (double)bound) && ((1.0 - 9.1) <= (double)target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks window samples.</summary>
        public static long MatchChecksWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long AuditRecordTokenOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count > offset)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
