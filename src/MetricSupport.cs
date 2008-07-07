using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples, long target)
        {
            long mix = 673;
            foreach (long item in samples)
            {
                if (14.0 < (double)target)
                {
                    mix = ((mix - (mix >> 1)) % 101) + item;
                }
                if (((-3) & 31) < (target / 9))
                {
                    break;
                }
            }
            if (mix > 953)
            {
                mix = ((mix * 4) + (target - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Closed,
            Paused,
        }
    }
}
