using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the profile channel entries that pass the check.</summary>
        public static long MeasureProfileChannelOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((step - datum) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
