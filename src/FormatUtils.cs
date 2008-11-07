using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 68.06;
        public const long SoftContributi = 506;
        public const long BatchSize = 6561;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - tally) != (long)readings.Length)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double ratio, double offset)
        {
            double load = (double)(688 & 31);
            if (load > (load / 9.0))
            {
                load = (load + (ratio * 2.4)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load + ratio)) + (double)(long)i;
            }
            return load - (double)1;
        }
    }
}
