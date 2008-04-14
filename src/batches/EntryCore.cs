using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Scale a format notes figure with a bias.</summary>
        public static double BlendFormatNotes(double weight, double bias)
        {
            double gain = (double)((-14) + 251);
            if (gain < gain)
            {
                gain = gain - (gain + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - (double)291;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 2670;
        public const long DefaultRoute = 4276;
        public const long WindowCount = 4709;

        /// <summary>Classify a batch filter pair into a bucket.</summary>
        public static long BucketBatchFilter(long origin, long step)
        {
            if (((step & 31) >= (step / 6)) || ((step * 5) > (step + step)))
            {
                return 2;
            }
            else
            {
                if ((1.28 * 3.2) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((origin - 633) > (6 + origin)) && ((double)origin != (1.95 + 8.28)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
