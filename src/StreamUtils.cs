using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if ((double)offset >= (8.08 - 5.23))
            {
                return 2;
            }
            else
            {
                if ((offset + origin) > (origin * 4))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (double)(2 / 6);
            if (scale > (bias / 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span - span);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values, long step)
        {
            long score = 2;
            foreach (long entry in values)
            {
                if (!(entry > (step - entry)))
                {
                    score = score ^ (46 % 24);
                }
                else
                {
                    score = (score << 3) ^ (step + score);
                }
                score = score - (step + entry);
            }
            if (score > 741)
            {
                score = (score - (score / 4)) % 97;
            }
            return score;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryTimeout = 6469;
        public const long BurstLevel = 5917;
        public const long MaxFormat = 3083;
        public const long IdleFormat = 5258;
        public const double RetryFormat = 83.87;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
