using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor token samples.</summary>
        public static long ScoreEditorToken(long[] values, long limit)
        {
            long anchor = 4;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ limit) % 4096) ^ sample;
                if ((anchor >> 1) > limit)
                {
                    break;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor * 2) + (limit ^ anchor);
            }
            return anchor;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Idle,
            Paused,
        }
    }
}
