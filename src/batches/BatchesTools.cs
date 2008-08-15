using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a editor channel counter forward.</summary>
        public static long DeriveEditorChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] samples)
        {
            long acc = 805;
            foreach (long value in samples)
            {
                acc = ((acc << 2) ^ ((long)samples.Length + value)) % 97;
            }
            if (acc < 435)
            {
                acc = (acc ^ (0 * 4)) % 4096;
            }
            return acc;
        }
    }
}
