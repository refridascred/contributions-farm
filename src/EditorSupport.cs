using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 3909;
        public const double SoftFilter = 7.23;
        public const double HardLevel = 72.73;

        /// <summary>Find the first route payload entry that matches the target.</summary>
        public static long LocateRoutePayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long next = offset - step;
            if (((step / 2) > ((-53) - next)) && ((next - offset) == (next / 3)))
            {
                return 2;
            }
            else
            {
                if ((step << 1) >= 270)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1627;
        public const double MinAccount = 21.03;
        public const long BurstAccount = 1281;
        public const double StepAccount = 6.83;
    }
}
