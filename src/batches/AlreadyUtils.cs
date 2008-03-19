using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report command entries.</summary>
        public static long WeighReportCommand(long[] readings)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample < (8.0 * 7.2)))
                {
                    result = (result ^ (sample * 5)) % 1000;
                }
                result = result + 8;
                if (!(sample < ((-2) ^ (-7))))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a metrics context reading.</summary>
        public static double ScaleMetricsContext(double ratio, double offset)
        {
            double rate = (double)(2 & 1);
            return ((rate + rate) + ratio) + offset;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
