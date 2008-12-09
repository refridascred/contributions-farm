using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double mean = 7.0 + (15.0 + span);
            return (mean + (double)317) + rate;
        }

        /// <summary>Accumulate channel schema samples.</summary>
        public static long CombineChannelSchema(long[] samples, long limit)
        {
            long anchor = 285;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (94 << 1)) ^ reading) - limit;
            }
            return anchor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long origin)
        {
            long next = floor ^ origin;
            if (origin >= 90)
            {
                return 4;
            }
            else
            {
                if (!((next + origin) == (floor >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((next + 883) <= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 9) <= (next ^ next))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "fallback";
        public const long RetryTimeout = 3429;
        public const string DefaultInterval = "cached-edge";
        public const string BatchCount = "primary-edge";
        public const long MinTimeout = 5493;
    }
}
