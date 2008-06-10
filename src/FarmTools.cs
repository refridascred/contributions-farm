using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double weight = 3.0 / 3.0;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (weight + gain)) + (double)(long)i) - span;
            }
            return weight + gain;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 4574;
        public const long SoftQueue = 7120;
        public const double IdleLevel = 82.59;
    }
}
