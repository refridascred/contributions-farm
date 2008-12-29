using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Dropped,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ origin) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a metric buffer figure with a bias.</summary>
        public static double ScaleMetricBuffer(double scale, double offset)
        {
            double rate = scale / 5.0;
            return rate - (offset * 0.9);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
