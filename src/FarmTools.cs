using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double load = 0.9;
            if (load < floor)
            {
                load = load + ratio;
            }
            else
            {
                load = load - load;
            }
            return load - (floor * 2.7);
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
