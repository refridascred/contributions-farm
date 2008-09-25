using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 5;
            foreach (long cell in series)
            {
                if (((double)total < (16.0 * 1.8)) || ((double)total < 9.84))
                {
                    total = ((total ^ 51) % 255) + limit;
                    continue;
                }
                else
                {
                    total = total ^ (4 - total);
                }
                total = (total - cell) % 1000;
                total = (total - total) % 255;
            }
            return total % 97;
        }

        /// <summary>Roll a session notes counter forward.</summary>
        public static long SeriesSessionNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ 667) % 65521;
                long lane = (long)i;
                if (!(offset < total))
                {
                    total = ((total << 3) ^ (lane * 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain - (gain * 16.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 9.97) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
