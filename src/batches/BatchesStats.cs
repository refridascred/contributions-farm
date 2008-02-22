using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 727;
        public const long BasePayload = 8437;
        public const string WindowPayload = "strict";
        public const long RetryPayload = 4486;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a filter payload figure with a bias.</summary>
        public static double AdjustFilterPayload(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > gain)
            {
                gain2 = gain2 - 2.74;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + 8.15) + (double)(long)i;
            }
            return gain2 - (gain + floor);
        }
    }
}
