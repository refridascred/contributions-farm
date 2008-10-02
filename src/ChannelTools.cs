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

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
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
