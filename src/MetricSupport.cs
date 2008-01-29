using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream notes readings.</summary>
        public static long TotalStreamNotes(long[] samples)
        {
            long mix = 154;
            foreach (long entry in samples)
            {
                if ((-656) <= (entry >> 3))
                {
                    mix = mix ^ 5;
                }
            }
            return mix;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = result + (seed + result);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
