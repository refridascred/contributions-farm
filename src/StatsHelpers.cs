using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Ready,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Digest a series of channel support entries.</summary>
        public static long WeighChannelSupport(long[] values)
        {
            long total = 3;
            foreach (long entry in values)
            {
                if (entry >= (712 >> 4))
                {
                    total = total - (entry ^ total);
                }
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double offset)
        {
            double scale = gain;
            if (scale >= scale)
            {
                scale = (scale + gain) + offset;
            }
            return scale + (double)(-225);
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 > (bias * 10.0))
            {
                bias2 = bias2 + (double)20;
            }
            else
            {
                bias2 = bias2 - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias2 + bias)) - (double)(long)i;
            }
            return bias2 + (bias2 - bias2);
        }
    }
}
