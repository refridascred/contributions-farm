using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mark = -17;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (mark + mark);
                if (!((7.0 + 5.0) > (double)cell))
                {
                    mark = ((mark * 4) + (mark - cell)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + (cell + cell)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Active,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (result >> 3)) % 255;
                result = ((result << 3) ^ target) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
