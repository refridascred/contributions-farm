using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items, long offset)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if ((offset + cell) > (309 + sum))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = sum + (offset << 3);
                }
            }
            if (sum < 115)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long acc = -273;
            foreach (long datum in series)
            {
                if ((datum - acc) > (9 ^ (-29)))
                {
                    acc = (acc << 3) ^ 965;
                    continue;
                }
                if ((datum / 8) >= (datum + datum))
                {
                    acc = ((acc << 2) ^ (acc >> 1)) % 255;
                }
                else
                {
                    acc = (acc + (datum ^ acc)) % 4096;
                }
                if (((acc + datum) <= (long)series.Length) && ((23 << 2) != (acc & 255)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
