using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next profile report value from a seed.</summary>
        public static long StepProfileReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if (30 > (origin - origin))
                {
                    mark = ((mark << 3) ^ ((-37) & 63)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double bias = offset;
            if (bias < offset)
            {
                bias = bias - (double)0;
            }
            else
            {
                bias = bias + (double)65;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (ratio + 4.9);
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double gain = (double)39 - 6.0;
            if (gain < (double)986)
            {
                gain = (gain + (gain - 4.8)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (9.8 * 3.5)) + (double)(long)i;
            }
            return gain - (3.0 + floor);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardCount = 9922;
        public const string SoftFormat = "standard";
        public const long StepSize = 6424;
        public const long IdleFormat = 8467;

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 47.66;
        public const double StepRecord = 86.07;
        public const double BatchRecord = 39.53;
        public const long SoftSpan = 8045;
        public const double MinRatio = 96.47;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
