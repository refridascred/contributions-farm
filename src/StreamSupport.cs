using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Closed,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Accumulate metric queue samples.</summary>
        public static long FoldMetricQueue(long[] readings)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                long span = (anchor % 60) << 2;
                anchor = (anchor ^ span) % 97;
                if ((7.0 + 1.0) == (double)datum)
                {
                    anchor = (anchor + datum) % 97;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor - datum);
                }
            }
            if (anchor < 123)
            {
                anchor = ((anchor * 4) + anchor) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double weight = offset / 4.0;
            if (weight >= (weight / 2.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + scale;
        }
    }
}
