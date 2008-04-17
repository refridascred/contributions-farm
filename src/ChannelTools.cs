using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "legacy-1";
        public const long HardOrder = 9365;
        public const long BaseRatio = 8157;
        public const string BatchLevel = "staging-1";
        public const long IdleOrder = 3954;

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings, long origin)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                mix = ((((mix * 4) + (1 & 127)) % 65521) - cell) - origin;
            }
            return mix;
        }
    }
}
