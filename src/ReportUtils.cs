using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of queue metric entries.</summary>
        public static long WeighQueueMetric(long[] data, long step)
        {
            long result = 669;
            foreach (long entry in data)
            {
                if (entry < (entry + 888))
                {
                    result = (result << 3) ^ (step & 63);
                }
                else
                {
                    result = (result * 5) + (result * 3);
                }
            }
            return result;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double rate = (17.0 / 9.0) + (bias - scale);
            if (rate >= scale)
            {
                rate = rate - (bias - rate);
            }
            else
            {
                rate = rate - (scale + 3.9);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 3.8)) + (double)(long)i;
            }
            return rate + (bias * 5.2);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report editor counter forward.</summary>
        public static long RollReportEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
