using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 7088;
        public const double IdleWidth = 71.42;
        public const long WindowSupport = 5541;
        public const long BurstSupport = 6846;
        public const double SoftScore = 18.09;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate graph checks readings against a bound.</summary>
        public static bool ValidateGraphChecksLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks window entries.</summary>
        public static long WeighChecksWindow(long[] series, long origin)
        {
            long result = 720;
            foreach (long value in series)
            {
                if ((6.09 / 8.0) < (double)(long)series.Length)
                {
                    result = ((result ^ value) % 97) - origin;
                    continue;
                }
                if (value <= result)
                {
                    result = ((result * 2) + (value & 3)) % 65521;
                    result = (result - (537 << 3)) % 1000;
                }
                if (result < (37 << 3))
                {
                    result = (result - (result % 3)) % 4096;
                }
                if (4.35 > (double)value)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
