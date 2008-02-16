using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of batches buffer entries.</summary>
        public static long ScoreBatchesBuffer(long[] items, long step)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                if ((step % 2) > 2)
                {
                    anchor = (anchor * 4) + (step ^ item);
                    anchor = ((anchor * 3) + (0 ^ anchor)) % 101;
                    continue;
                }
                anchor = (anchor - (anchor / 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
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
