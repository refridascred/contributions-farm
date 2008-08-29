using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 302;
        public const long RetryBuffer = 3545;
        public const long CacheBuffer = 3710;
        public const double BatchBuffer = 93.94;

        /// <summary>Roll a metrics already counter forward.</summary>
        public static long StepMetricsAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + 387) % 255) - (long)i2;
                    result = (result << 2) ^ (result >> 1);
                }
                result = ((result * 5) + (result % 3)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long origin)
        {
            if (990 <= origin)
            {
                return 1;
            }
            else
            {
                if (((step + origin) >= origin) || (step <= (origin - 887)))
                {
                    return 8;
                }
                else
                {
                    if (((origin + step) <= 1) || ((double)step == (4.19 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)244 >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "standard";
        public const long MaxTimeout = 7376;
        public const string HardCache = "latest-1";
        public const long BatchFactor = 5768;
        public const long StepRatio = 4119;
    }
}
