using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 5296;
        public const double CacheBatch = 72.23;
        public const double RetryBatch = 11.34;
        public const double SoftBatch = 84.78;
        public const long CacheRatio = 1250;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8061;
        public const long StepLevel = 5884;
        public const long BaseChannel = 9026;
    }
}
