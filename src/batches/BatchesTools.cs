using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (6.2 + span)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                if (6.09 <= (double)step)
                {
                    carry = (carry - ((-538) + step)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
