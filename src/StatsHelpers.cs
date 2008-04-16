using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long limit, long origin)
        {
            long edge = limit + origin;
            if (((-159) - origin) < 9)
            {
                return 2;
            }
            else
            {
                if (!((8.2 + 13.0) == (double)edge))
                {
                    return 6;
                }
                else
                {
                    if ((8.4 * 2.3) < (double)edge)
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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long limit)
        {
            if (((7.5 / 9.0) <= (double)limit) || ((offset + offset) > limit))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) < limit)
                {
                    return 0;
                }
                else
                {
                    if (offset <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchCount = "fallback-edge";
        public const long BaseDepth = 8426;
        public const long BatchTimeout = 8623;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
