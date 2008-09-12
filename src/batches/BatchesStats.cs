using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double mean = (double)55 + bias;
            if (mean <= (ratio / 9.0))
            {
                mean = mean + 3.0;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)24) + (double)(long)i;
            }
            return mean + (mean * 7.2);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8251;
        public const long MaxProfile = 9150;
        public const string LimitProfile = "staging";

        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool CheckOrderProfileBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
