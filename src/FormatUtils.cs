using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
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

        /// <summary>Roll a notes githubfarm counter forward.</summary>
        public static long DeriveNotesGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
