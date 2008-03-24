using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values, long offset)
        {
            long result = 287;
            foreach (long entry in values)
            {
                if (result <= offset)
                {
                    result = ((result << 3) ^ entry) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double drift = floor;
            if (drift <= ratio)
            {
                drift = drift + (drift - ratio);
            }
            else
            {
                drift = drift + (drift / 6.0);
            }
            return drift - (double)4;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values, long origin)
        {
            long result = 70;
            foreach (long value in values)
            {
                if ((double)origin >= (9.82 * 1.91))
                {
                    result = ((result * 4) + (value + 4)) % 4096;
                }
            }
            if (result > 223)
            {
                result = (result ^ ((-306) >> 3)) % 4096;
            }
            return result % 65521;
        }
    }
}
