using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSize = 9371;
        public const long IdleQueue = 563;
        public const double MinQueue = 54.11;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double gain2 = (double)(8 ^ 5);
            if (gain2 <= gain2)
            {
                gain2 = (gain2 - (gain * 8.8)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - gain;
        }
    }
}
