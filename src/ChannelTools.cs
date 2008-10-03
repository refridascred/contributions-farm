using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double drift = bias;
            if (drift >= (drift - bias))
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (7.11 - bias)) + (double)(long)i;
            }
            return drift + (double)(-781);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value <= (double)floor)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Locked,
            Pending,
            Paused,
            Closed,
        }
    }
}
