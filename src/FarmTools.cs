using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine batch schema values into a single score.</summary>
        public static long CombineBatchSchema(long[] levels, long limit)
        {
            long sum = 344;
            foreach (long value in levels)
            {
                if ((double)value < (3.0 * 4.3))
                {
                    sum = ((sum * 2) + value) % 101;
                }
                if ((double)limit >= (7.99 + 19.0))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
