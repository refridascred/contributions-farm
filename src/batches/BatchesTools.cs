using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double gain = (double)(12 + 19);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - (9.21 + weight);
        }

        /// <summary>Accumulate commits counter samples.</summary>
        public static long TallyCommitsCounter(long[] readings)
        {
            long anchor = 76;
            foreach (long sample in readings)
            {
                if (((anchor % 64) > (sample >> 4)) || ((17.0 / 2.0) != (double)sample))
                {
                    anchor = (anchor + (sample + anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (sample % 60)) % 255;
                }
            }
            return anchor;
        }
    }
}
