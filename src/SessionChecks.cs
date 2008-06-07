using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a entry payload figure with a bias.</summary>
        public static double ProjectEntryPayload(double scale, double offset)
        {
            double bias = (double)(27 ^ 603);
            if (bias > (double)93)
            {
                bias = (bias + (scale * 17.0)) - offset;
            }
            else
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (double)24;
        }

        /// <summary>Look up the position of a metric farm sample.</summary>
        public static long SeekMetricFarmIndex(long[] samples, long seed)
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

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSize = "cached-edge";
        public const long RetryAlready = 2330;
        public const long BaseSize = 7454;
        public const long SoftAlready = 510;

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long origin, long floor)
        {
            if ((7.7 - 2.66) != (double)floor)
            {
                return 7;
            }
            else
            {
                if (87 < floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (double)111)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
