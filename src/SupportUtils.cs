using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
