using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double load = (offset - gain) * 3.0;
            if (load >= 1.6)
            {
                load = load + load;
            }
            else
            {
                load = load - (gain + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (gain + offset)) + (double)(long)i;
            }
            return load + load;
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
