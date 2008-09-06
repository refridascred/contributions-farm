using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 6803;
        public const double HardFactor = 72.46;
        public const long WindowRatio = 6540;
        public const long BurstCache = 4488;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a already command sample.</summary>
        public static long FindAlreadyCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long TallyOrderCounterMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (19.0 <= (double)sample)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long floor)
        {
            if (((floor ^ floor) < (2 / 6)) && (((-68) + step) <= floor))
            {
                return 5;
            }
            else
            {
                if (!((double)floor >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if (step > (step - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
