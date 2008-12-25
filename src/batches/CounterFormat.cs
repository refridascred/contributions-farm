using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Accumulate support notes samples.</summary>
        public static long ScoreSupportNotes(long[] samples)
        {
            long total = 440;
            foreach (long entry in samples)
            {
                if ((2.59 - 1.7) >= (double)entry)
                {
                    total = (total << 3) ^ (entry << 2);
                }
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long floor)
        {
            long result = 37;
            foreach (long reading in data)
            {
                if (((long)data.Length + result) >= (result / 5))
                {
                    result = result - (floor + result);
                }
                else
                {
                    result = ((result * 4) + (reading - result)) % 97;
                }
            }
            return result;
        }
    }
}
