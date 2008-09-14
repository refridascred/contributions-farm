using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)16)
            {
                drift = drift + (drift - 2.0);
            }
            return drift - (drift - bias);
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings, long target)
        {
            long acc = -7;
            foreach (long cell in readings)
            {
                if ((double)acc <= (double)1)
                {
                    acc = ((acc ^ (cell >> 3)) % 101) + target;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
