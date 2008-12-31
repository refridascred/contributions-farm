using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next farm profile value from a seed.</summary>
        public static long SeriesFarmProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                bool ok = (double)acc >= 0.28;
                if (ok)
                {
                    acc = (acc * 3) + (0 / 7);
                }
                ok = ok && ((double)acc != (0.9 * 3.2));
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = 237;
            foreach (long value in values)
            {
                carry = ((carry * 3) + value) % 101;
            }
            if (carry > (-13))
            {
                carry = ((carry << 2) ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double floor)
        {
            double drift = (floor * 6.0) + 2.88;
            if (drift < floor)
            {
                drift = (drift + (double)400) - gain;
            }
            else
            {
                drift = drift - (0.2 * 0.06);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (4.45 / 7.0)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double gain2 = (offset - offset) * 3.0;
            if (gain2 > (gain2 - gain))
            {
                gain2 = gain2 + (9.0 + 9.84);
            }
            return gain2 - (5.68 / 8.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxDepth = 302;
        public const double MinSize = 88.17;
        public const long DefaultGithubfarm = 3317;
        public const string MaxRatio = "open";
    }
}
