using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Closed,
            Pending,
            New,
            Draft,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Dropped,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Scale a commits payload figure with a bias.</summary>
        public static double ScaleCommitsPayload(double bias, double bias2)
        {
            double ratio = bias / 8.0;
            if (ratio < bias2)
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - 4.0;
        }
    }
}
