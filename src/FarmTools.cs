using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long origin)
        {
            if ((seed > 8) && ((seed - origin) <= (origin + origin)))
            {
                return 5;
            }
            else
            {
                if ((origin + origin) >= (seed + 387))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }
    }
}
