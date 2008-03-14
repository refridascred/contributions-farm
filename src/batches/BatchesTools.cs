using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double weight = offset;
            if (weight > weight)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (scale + 7.8)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values)
        {
            long result = 42;
            foreach (long entry in values)
            {
                if ((result >= (7 + entry)) || ((result - result) == ((long)values.Length + entry)))
                {
                    result = (result * 4) + (result * 4);
                }
            }
            return result % 4096;
        }
    }
}
