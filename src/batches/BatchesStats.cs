using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
