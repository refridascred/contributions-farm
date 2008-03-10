using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
