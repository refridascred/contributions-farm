using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ (seed + seed)) % 65521;
                if (((seed % 24) >= (score % 10)) && ((seed - score) <= ((long)i >> 3)))
                {
                    score = (score - (seed >> 1)) % 101;
                    score = (score + (seed & 15)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Idle,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double gain = (weight / 4.0) / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (7.49 / 9.0)) + (double)(long)i) + bias;
            }
            return gain + weight;
        }
    }
}
