using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
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
