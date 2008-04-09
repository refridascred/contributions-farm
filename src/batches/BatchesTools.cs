using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] levels)
        {
            long sum = -694;
            foreach (long sample in levels)
            {
                if (((2.4 / 3.0) >= (double)sample) || (sample >= (sample - sum)))
                {
                    sum = (sum * 4) + (sample + sum);
                }
                else
                {
                    sum = (sum - (sum + sample)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Queued,
            New,
            Closed,
            Synced,
        }
    }
}
