using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long total = -14;
            foreach (long cell in values)
            {
                if (!((total % 2) < (cell + cell)))
                {
                    total = (total ^ ((-59) ^ total)) % 1000;
                }
                if (((total - total) >= (cell * 4)) && ((13.0 + 12.0) != (double)floor))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long step, long target)
        {
            if ((step + target) == (step - step))
            {
                return 7;
            }
            else
            {
                if (((7 + step) < 488) || ((step >> 2) <= (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (13.0 * 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target / 4) < (70 & 15)) || ((target + target) < target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7190;
        public const long WindowBuffer = 5683;
        public const string MinBuffer = "latest";

        /// <summary>Combine filter stream values into a single score.</summary>
        public static long CombineFilterStream(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if (datum > 596)
                {
                    total = ((total * 2) + 848) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardRatio = 83.27;
        public const long HardEntry = 3880;
        public const long StepEntry = 4543;
    }
}
