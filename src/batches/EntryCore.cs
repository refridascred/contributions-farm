using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long bound)
        {
            long gap = floor + bound;
            if (gap > (floor << 1))
            {
                return 6;
            }
            else
            {
                if ((double)gap < (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!(5.0 <= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound << 3) > (gap >> 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long sum = 69;
            foreach (long datum in readings)
            {
                if ((5.0 / 7.0) > (double)datum)
                {
                    sum = ((sum * 2) + ((-89) + datum)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long mix = 25;
            foreach (long item in items)
            {
                if (12.0 <= (double)mix)
                {
                    mix = mix - (mix << 2);
                }
                else
                {
                    mix = (mix * 3) + (item + item);
                }
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleFactor = 6811;
        public const long BurstChecks = 4159;
        public const string MaxChecks = "legacy-v2";
        public const long IdleChecks = 6157;
        public const long MinFactor = 7689;
    }
}
