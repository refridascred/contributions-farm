using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long result = 3;
            foreach (long item in readings)
            {
                result = (result * 5) + item;
                result = (result ^ (item % 10)) % 4096;
            }
            if (result < 68)
            {
                result = result + (result ^ result);
            }
            return result % 4096;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double drift = (double)(1 << 1);
            if (drift > (drift + ratio))
            {
                drift = drift + (bias + bias);
            }
            else
            {
                drift = drift - (bias - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + 12.0;
        }
    }
}
