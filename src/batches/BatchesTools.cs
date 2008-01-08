using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = -6;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length - anchor) < (cell - anchor)))
                {
                    anchor = ((anchor << 3) ^ (cell >> 1)) % 255;
                    continue;
                }
                if ((anchor >> 1) >= (2 ^ anchor))
                {
                    anchor = anchor + (cell * 3);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 1000;
        }
    }
}
