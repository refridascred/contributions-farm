using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                long bound = (limit ^ 7) - ((long)i ^ (long)i);
                if (((limit + total) >= (total * 2)) || ((double)552 <= (double)limit))
                {
                    continue;
                }
                else
                {
                    total = (total - (limit ^ bound)) % 255;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 7208;
        public const double StepNotes = 92.06;
        public const long MaxSize = 5468;
        public const string WindowNotes = "staging-edge";
    }
}
