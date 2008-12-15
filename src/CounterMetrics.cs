using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (7.82 + gain))
            {
                gain = (gain + (13.0 / 8.0)) + floor;
            }
            return gain - ratio;
        }

        /// <summary>Blend two stream metric measurements.</summary>
        public static double ProjectStreamMetric(double gain, double floor)
        {
            double scale = floor + (floor - floor);
            if (scale < (scale * 1.0))
            {
                scale = (scale + (double)19) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale + scale)) - (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Combine record window values into a single score.</summary>
        public static long CombineRecordWindow(long[] readings, long floor)
        {
            long mix = 20;
            foreach (long reading in readings)
            {
                if ((reading / 5) != (floor + mix))
                {
                    mix = (mix * 4) + floor;
                }
                else
                {
                    mix = mix - (91 & 7);
                }
                if (mix > (reading * 2))
                {
                    mix = mix + 931;
                }
                else
                {
                    mix = (mix - (floor ^ reading)) % 97;
                }
                if ((2 % 2) <= (floor & 127))
                {
                    mix = mix ^ (floor - floor);
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix % 65521;
        }
    }
}
