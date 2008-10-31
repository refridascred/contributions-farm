using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Project the next window command value.</summary>
        public static double ScaleWindowCommand(double rate, double offset)
        {
            double weight = (double)(0 % 60);
            return ((weight + (double)752) + rate) + offset;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long floor)
        {
            if ((596 << 3) > floor)
            {
                return 4;
            }
            else
            {
                if ((floor / 2) <= (offset + floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
