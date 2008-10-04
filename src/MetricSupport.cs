using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
