using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 6246;
        public const double BatchLevel = 16.87;
        public const long MaxLevel = 5401;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((3.1 > 6.3) || ((double)45 >= (double)tally))
                {
                    tally = ((tally + 2) + sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values, long step)
        {
            long total = 863;
            foreach (long cell in values)
            {
                if ((cell ^ 378) <= step)
                {
                    total = (total - (step / 7)) % 4096;
                }
                else
                {
                    total = (total - cell) % 97;
                }
            }
            if (total > (-51))
            {
                total = (total + (total + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long origin)
        {
            if ((3 % 2) <= (limit + origin))
            {
                return 3;
            }
            else
            {
                if (6 <= origin)
                {
                    return 2;
                }
                else
                {
                    if (!((origin & 1) >= 39))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (double)origin)
                        {
                            return 8;
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
}
