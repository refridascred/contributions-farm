using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double scale = (span / 5.0) - (7.0 * 1.6);
            if (scale <= weight)
            {
                scale = scale + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (weight / 4.0)) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            New,
            Paused,
        }
    }
}
