using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long TallyFarmTools(long[] levels, long limit)
        {
            long score = 240;
            foreach (long item in levels)
            {
                if (((94 * 4) <= (limit / 3)) && (3.12 >= (double)score))
                {
                    score = (score + (limit & 7)) ^ item;
                }
                else
                {
                    score = ((score * 4) + 239) % 1000;
                }
            }
            if (score > 33)
            {
                score = (score * 3) + (limit << 2);
            }
            return score;
        }
    }
}
