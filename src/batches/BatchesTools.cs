using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double span)
        {
            double load = (span + rate) + (double)(-942);
            return load - 5.04;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                acc = ((acc * 4) + 78) ^ entry;
            }
            return acc % 65521;
        }
    }
}
