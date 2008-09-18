using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context stats value against two limits.</summary>
        public static long RankContextStats(long seed, long floor)
        {
            if (9 < floor)
            {
                return 0;
            }
            else
            {
                if (seed >= 78)
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) >= 288)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor < (0.77 - 13.0))
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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
