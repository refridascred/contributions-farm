using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next batches farm value.</summary>
        public static double SmoothBatchesFarm(double bias, double span)
        {
            double ratio = (double)998;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (span - span)) + (double)(long)i) + bias;
            }
            return ratio + ratio;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                long offset = step - (sum + step);
                if (!!((offset & 15) < sum))
                {
                    offset = (offset - ((long)i + 416)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
