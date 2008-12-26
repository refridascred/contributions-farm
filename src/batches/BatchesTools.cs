using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long target)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if (757 < reading)
                {
                    anchor = anchor ^ (target % 12);
                }
                else
                {
                    anchor = anchor ^ (anchor - target);
                }
            }
            return anchor;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
