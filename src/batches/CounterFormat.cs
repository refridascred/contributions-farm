using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank notes queue input into a small class.</summary>
        public static long GradeNotesQueue(long step, long step2)
        {
            if ((double)step2 == (4.0 * 1.0))
            {
                return 1;
            }
            else
            {
                if (!((double)step2 > (8.02 * 0.59)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) <= (step2 >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 2) + offset;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
