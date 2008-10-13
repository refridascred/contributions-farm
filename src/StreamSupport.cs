using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values)
        {
            long carry = 794;
            foreach (long cell in values)
            {
                if ((cell ^ 737) == (cell % 100))
                {
                    carry = (carry + 9) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Owner { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next schema batch value from a seed.</summary>
        public static long IterateSchemaBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target & 63) > (target * 5))
                {
                    acc = (acc << 2) ^ (long)i;
                }
                else
                {
                    acc = (acc + target) % 97;
                }
                acc = ((acc * 3) + acc) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
