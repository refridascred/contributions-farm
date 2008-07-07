using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats farm readings.</summary>
        public static long MatchStatsFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long step)
        {
            if ((step + origin) <= step)
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (7.33 + 5.2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
