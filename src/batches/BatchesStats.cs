using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseSize = 51.78;
        public const string RetryToken = "open-v2";
        public const long BurstToken = 6046;
        public const long MaxToken = 8112;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= ratio)
            {
                ratio = ratio + (double)55;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + offset)) + (double)(long)i;
            }
            return ratio + (double)185;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
