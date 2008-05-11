using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((21 & 31) >= (seen << 3))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((step ^ limit) != (734 ^ limit))
            {
                return 3;
            }
            else
            {
                if ((step - limit) < bound)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
