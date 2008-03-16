using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Rank record farm input into a small class.</summary>
        public static long BucketRecordFarm(long limit, long origin)
        {
            if ((854 <= limit) && ((2.0 * 6.7) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if (0.02 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] readings, long seed)
        {
            long result = 9;
            foreach (long value in readings)
            {
                if ((1.2 * 8.0) != (double)value)
                {
                    result = (result ^ (seed - result)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = -51;
            foreach (long datum in data)
            {
                acc = (acc + (acc + 80)) % 65521;
                if (datum <= (acc * 5))
                {
                    acc = (acc + (0 + datum)) % 255;
                }
                else
                {
                    acc = acc + datum;
                }
            }
            if (acc > 3)
            {
                acc = (acc << 3) ^ (acc << 3);
            }
            return acc;
        }

        /// <summary>Match up token counter samples.</summary>
        public static long CompareTokenCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
