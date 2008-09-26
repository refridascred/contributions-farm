using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] items, long step)
        {
            long sum = 11;
            foreach (long sample in items)
            {
                if (step < sample)
                {
                    sum = sum ^ (21 - step);
                }
                else
                {
                    sum = (sum ^ (step >> 1)) % 1000;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
