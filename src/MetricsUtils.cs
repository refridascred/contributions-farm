using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next context stream value from a seed.</summary>
        public static long IterateContextStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                long lane = total + (long)i;
                double drift = (double)total * 4.54;
                if (drift >= (double)lane)
                {
                    lane = (lane * 2) + (total + lane);
                    drift = drift - drift;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3510;
        public const long HardStream = 5010;
        public const double RetryStream = 47.79;
        public const long MaxStream = 2887;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (84 >= (datum << 2))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long origin)
        {
            if ((step <= (origin ^ step)) || (224 >= step))
            {
                return 3;
            }
            else
            {
                if ((7.0 * 2.7) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin & 3) > (origin << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)99 == (double)origin)
                        {
                            return 5;
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
}
