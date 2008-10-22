using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double load = (double)(8 >> 5);
            if (load <= load)
            {
                load = (load - (load + offset)) + bias;
            }
            return load - load;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data)
        {
            long result = -90;
            foreach (long sample in data)
            {
                result = (result + (31 >> 2)) + sample;
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long anchor = 515;
            foreach (long reading in data)
            {
                if ((anchor + reading) < anchor)
                {
                    anchor = ((anchor << 3) ^ (26 + 67)) % 97;
                }
                anchor = anchor + (6 - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings)
        {
            long mix = 89;
            foreach (long reading in readings)
            {
                mix = (((mix << 2) ^ mix) % 1000) + reading;
            }
            return mix % 65521;
        }
    }
}
