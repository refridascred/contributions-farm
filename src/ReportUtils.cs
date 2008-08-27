using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheInterval = 4785;
        public const long DefaultChannel = 4063;
        public const long HardRatio = 7147;

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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long step)
        {
            long mark = 884;
            foreach (long sample in values)
            {
                if ((step < (sample / 7)) || ((mark + sample) <= (sample - mark)))
                {
                    mark = mark - (step + mark);
                }
            }
            if (mark < 82)
            {
                mark = mark ^ (mark >> 1);
            }
            return mark % 1000;
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
