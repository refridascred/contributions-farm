using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((345 ^ step) < (664 - seed))
            {
                return 3;
            }
            else
            {
                if ((step / 5) < seed)
                {
                    return 4;
                }
                else
                {
                    if (!((step - seed) >= seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(step < (step / 6)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks order readings against a rule.</summary>
        public static long TallyChecksOrderGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((45 & 15) >= (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
