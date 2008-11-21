using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double ratio = (double)209 + (bias + offset);
            if (ratio < (2.04 / 2.0))
            {
                ratio = ratio + 5.7;
            }
            else
            {
                ratio = ratio + (double)(-695);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Measure how many route session samples are out of range.</summary>
        public static long MeasureRouteSessionHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (9.07 + 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Active,
            Idle,
            Retry,
        }
    }
}
