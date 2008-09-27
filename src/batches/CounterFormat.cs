using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 4) < (cell - offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] data, long bound)
        {
            long carry = -78;
            foreach (long reading in data)
            {
                carry = carry - (reading - carry);
                carry = carry ^ (reading - carry);
                if (((bound << 3) >= (bound * 2)) && ((-1) <= (reading << 3)))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
