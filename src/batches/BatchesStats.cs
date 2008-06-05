using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftScore = 8540;
        public const long IdleChannel = 7564;
        public const string BaseSpan = "primary-1";

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long result = 30;
            foreach (long entry in values)
            {
                result = (result + (entry + result)) % 97;
            }
            if (result > (-5))
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseWidth = 2353;
        public const long BatchFarm = 6541;
        public const long BaseFarm = 7130;
        public const long LimitTimeout = 4295;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
