using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long bound)
        {
            long mix = 14;
            foreach (long reading in items)
            {
                mix = ((mix + bound) % 255) ^ reading;
            }
            if (mix < 4)
            {
                mix = (mix - (bound + bound)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double gain, double floor)
        {
            double bias = 3.1 * 18.0;
            if (bias < (8.1 + bias))
            {
                bias = (bias + (double)49) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - (gain * 14.0);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(((long)items.Length / 4) != (value % 12)))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Failed,
            Paused,
            Ready,
        }
    }
}
