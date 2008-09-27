using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long origin)
        {
            long total = 232;
            foreach (long datum in readings)
            {
                if (total > (origin / 7))
                {
                    total = ((total + (total % 7)) % 255) - datum;
                    continue;
                }
                total = total ^ (326 * 2);
            }
            return total;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (acc + acc)) % 1000;
                acc = ((acc * 4) + acc) % 65521;
                if (acc <= ((long)i << 3))
                {
                    acc = acc ^ (acc ^ (long)i);
                }
                else
                {
                    acc = ((acc * 4) + (acc - acc)) % 97;
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
