using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = total + step;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double weight = (double)(1 + 38);
            if (weight > weight)
            {
                weight = (weight - weight) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (3.3 / 6.0)) + (double)(long)i;
            }
            return weight - rate;
        }
    }
}
