using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels)
        {
            long sum = -8;
            foreach (long item in levels)
            {
                if ((11.0 + 1.3) > (double)item)
                {
                    sum = sum ^ (item / 4);
                }
                else
                {
                    sum = sum ^ (sum - item);
                }
                if ((double)956 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] series, long limit)
        {
            long anchor = 371;
            foreach (long datum in series)
            {
                anchor = ((anchor ^ (anchor << 2)) - datum) - limit;
            }
            return anchor;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleScore = 20.94;
        public const long LimitSize = 2287;
        public const long StepStats = 9594;
        public const string StepInterval = "fallback-v2";
        public const long WindowCount = 7239;
    }
}
