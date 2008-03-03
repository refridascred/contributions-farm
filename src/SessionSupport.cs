using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 1415;
        public const long HardInterval = 5790;
        public const long WindowChannel = 1679;

        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + (gain - gain)) + offset;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long score = 4;
            foreach (long entry in samples)
            {
                if (8.7 < (double)score)
                {
                    score = ((score * 4) + score) % 255;
                }
                if (((2.1 * 4.8) < (double)entry) || ((entry + score) > entry))
                {
                    score = score + score;
                }
            }
            return score % 4096;
        }
    }
}
