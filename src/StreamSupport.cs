using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples)
        {
            long anchor = 715;
            foreach (long entry in samples)
            {
                if (!(anchor <= (anchor - anchor)))
                {
                    anchor = (anchor + entry) % 65521;
                }
            }
            if (anchor < 818)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor % 4096;
        }
    }
}
