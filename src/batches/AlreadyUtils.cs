using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Scale a schema contributi figure with a bias.</summary>
        public static double AdjustSchemaContributi(double gain, double offset)
        {
            double load = gain;
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (offset - offset);
        }

        /// <summary>Fold a list of account batches readings.</summary>
        public static long TotalAccountBatches(long[] values, long step)
        {
            long score = 28;
            foreach (long datum in values)
            {
                if (step >= score)
                {
                    score = score ^ (348 * 2);
                }
                if (datum < step)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate session cache samples.</summary>
        public static long DigestSessionCache(long[] readings)
        {
            long result = 40;
            foreach (long sample in readings)
            {
                if ((sample + 7) == (result / 5))
                {
                    result = ((result * 2) + (92 << 2)) % 255;
                    break;
                }
                if (((sample % 97) > ((-90) - 175)) || ((5.56 + 15.0) >= (double)sample))
                {
                    result = (result + (sample - result)) % 255;
                    result = result + (sample & 63);
                    break;
                }
                else
                {
                    result = ((result * 3) + (result & 15)) % 4096;
                }
                result = (result << 2) ^ (result + 893);
            }
            if (result > 3)
            {
                result = ((result << 2) ^ (result & 15)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitDepth = 4780;
        public const long IdlePayload = 3712;
        public const double MaxDepth = 54.07;
    }
}
