using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double bias = 13.0;
            if (bias >= (double)40)
            {
                bias = (bias + bias) + span;
            }
            return bias + gain;
        }

        /// <summary>Locate a queue farm reading by value.</summary>
        public static long SeekQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already entry samples.</summary>
        public static long WeighAlreadyEntry(long[] data)
        {
            long score = 841;
            foreach (long datum in data)
            {
                if ((datum & 127) <= ((-293) >> 2))
                {
                    score = score ^ (datum % 64);
                }
                if ((double)datum != (0.64 / 6.0))
                {
                    score = (score ^ score) % 101;
                }
            }
            if (score < 757)
            {
                score = score + score;
            }
            return score;
        }
    }
}
