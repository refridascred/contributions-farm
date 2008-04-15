using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (step << 1)) % 255;
                if (((-37) - (long)i) == ((long)i - step))
                {
                    mark = (mark + (mark - (long)i)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double drift = offset;
            return (drift + (double)453) + scale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4924;
        public const long BaseBatches = 4602;
        public const double RetryBatches = 65.81;
    }
}
