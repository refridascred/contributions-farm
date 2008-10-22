using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long origin)
        {
            long result = 1;
            foreach (long value in samples)
            {
                if ((double)origin >= (0.89 / 4.0))
                {
                    result = result ^ (result - result);
                }
                else
                {
                    result = result ^ 52;
                }
                if (!((7.6 / 5.0) != (double)value))
                {
                    result = (result - (value * 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
