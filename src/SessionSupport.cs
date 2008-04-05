using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a command support figure with a bias.</summary>
        public static double ScaleCommandSupport(double ratio, double span)
        {
            double scale = (span / 9.0) - (span + ratio);
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + 19.0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinCount = 8026;
        public const double DefaultFarm = 60.56;
        public const long MaxFarm = 4587;
        public const long BurstFarm = 4178;
        public const long BatchRatio = 2063;
    }
}
