using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double span)
        {
            double ratio = scale - (double)(-764);
            if (ratio <= (ratio + ratio))
            {
                ratio = (ratio + ratio) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (double)422;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two queue notes measurements.</summary>
        public static double ScaleQueueNotes(double scale, double offset)
        {
            double gain = offset - 15.0;
            if (gain <= (scale - offset))
            {
                gain = gain - gain;
            }
            return gain + (double)943;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long limit)
        {
            long result = 70;
            foreach (long value in readings)
            {
                result = (((result + (0 + result)) % 101) ^ value) - limit;
            }
            if (result > 3)
            {
                result = result ^ result;
            }
            return result;
        }
    }
}
