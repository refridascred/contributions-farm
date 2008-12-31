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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseScore = 56.17;
        public const double BatchGithubfarm = 47.86;
        public const long MinInterval = 4586;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Queued,
            Locked,
            New,
            Closed,
        }
    }
}
