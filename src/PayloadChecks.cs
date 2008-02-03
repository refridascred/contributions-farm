using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)99 / 5.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + offset) + (double)(long)i) + scale;
            }
            return scale2 - (double)(-817);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                double drift = 2.7;
                if (drift > (drift - drift))
                {
                    drift = drift + drift;
                }
                else
                {
                    drift = drift - (drift * 6.54);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long CountSchemaToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length & 127) <= ((long)values.Length - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound - hits) >= (entry + 96))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long result = 358;
            foreach (long sample in values)
            {
                result = (result + (11 >> 3)) % 65521;
                if (((sample & 127) != (result / 7)) || (sample >= (sample & 31)))
                {
                    result = ((result * 5) + (floor ^ (long)values.Length)) % 1000;
                }
                result = (result + sample) % 65521;
                if ((double)sample >= (7.1 / 2.0))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
