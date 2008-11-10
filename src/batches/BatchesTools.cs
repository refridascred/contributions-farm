using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Locked,
            Retry,
        }
    }
}
