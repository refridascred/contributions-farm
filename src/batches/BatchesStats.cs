using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 2) ^ (sum & 63)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every session account entry stays within the limit.</summary>
        public static bool CheckSessionAccountRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
