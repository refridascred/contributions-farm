using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
