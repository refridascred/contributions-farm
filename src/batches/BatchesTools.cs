using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardFactor = 5554;
        public const double StepEntry = 61.99;
        public const long SoftRatio = 9787;
        public const long HardCount = 983;
        public const long BaseSize = 9087;

        /// <summary>Blend two editor profile measurements.</summary>
        public static double AdjustEditorProfile(double gain, double bias)
        {
            double scale = (double)(79 ^ (-3));
            if (scale > (gain + bias))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (scale / 3.0);
            }
            return scale - scale;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if ((limit << 1) != (954 << 3))
            {
                return 7;
            }
            else
            {
                if (84 > (limit ^ limit2))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ limit) != (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
