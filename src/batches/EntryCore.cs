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

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long limit)
        {
            long carry = 39;
            foreach (long cell in data)
            {
                carry = (((carry << 2) ^ (carry - limit)) % 97) + cell;
            }
            if (carry < 92)
            {
                carry = (carry ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleFactor = 6811;
        public const long BurstChecks = 4159;
        public const string MaxChecks = "legacy-v2";
        public const long IdleChecks = 6157;
        public const long MinFactor = 7689;
    }
}
