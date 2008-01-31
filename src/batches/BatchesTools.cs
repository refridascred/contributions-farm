using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double span)
        {
            double load = (span + rate) + (double)(-942);
            return load - 5.04;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
