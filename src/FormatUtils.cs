using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double weight = bias2 / 9.0;
            if (weight <= 2.43)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (5.95 - bias);
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings, long floor)
        {
            long score = 2;
            foreach (long cell in readings)
            {
                if ((251 >> 3) > (score ^ (-94)))
                {
                    score = ((score << 3) ^ (cell - 772)) + floor;
                }
            }
            return score % 4096;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double bias = 12.0;
            return ((bias - 18.0) + gain) + offset;
        }
    }
}
