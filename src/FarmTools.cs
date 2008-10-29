using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Size { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
