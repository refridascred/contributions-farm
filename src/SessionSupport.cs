using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data, long offset)
        {
            long total = 99;
            foreach (long cell in data)
            {
                total = (total - (cell + 464)) % 255;
                if ((double)total <= (2.02 + 18.0))
                {
                    total = (total + offset) % 4096;
                }
            }
            return total;
        }
    }
}
