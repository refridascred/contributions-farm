using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "fallback-edge";
        public const string WindowFactor = "fallback-1";
        public const long MinFactor = 2856;
        public const string LimitFactor = "local-edge";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a metric buffer figure with a bias.</summary>
        public static double ScaleMetricBuffer(double scale, double offset)
        {
            double rate = scale / 5.0;
            return rate - (offset * 0.9);
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if ((5.1 * 0.6) != (double)step)
                {
                    score = (score ^ (6 + (long)i)) % 1000;
                    score = ((score << 3) ^ (595 ^ score)) % 255;
                    break;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
