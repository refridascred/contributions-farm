using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up cache editor samples.</summary>
        public static long OverlapCacheEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long mix = 63;
            foreach (long value in readings)
            {
                if ((3 << 3) > (value * 3))
                {
                    mix = (((mix * 4) + (value + value)) % 97) - limit;
                }
            }
            if (mix > 351)
            {
                mix = ((mix << 3) ^ (mix >> 5)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Locked,
            Paused,
        }
    }
}
