using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 2559;
        public const long HardEntry = 1254;
        public const long MinFactor = 8728;

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

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

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
