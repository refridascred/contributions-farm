using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double weight = offset * 0.62;
            if (weight > (gain + offset))
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset - offset)) - (double)(long)i;
            }
            return weight - (8.94 + gain);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc + limit) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Paused,
            Done,
        }
    }
}
