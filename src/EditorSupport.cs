using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(55 > tally))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long floor)
        {
            if ((limit >> 3) >= (42 + limit))
            {
                return 4;
            }
            else
            {
                if (((limit << 2) > (1 + 4)) && ((18.0 * 3.61) < (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor >= (9.0 * 9.0)) && ((floor * 4) > (848 - floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.37 * 0.87) <= (double)limit) || ((double)limit > 16.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long step)
        {
            long anchor = 919;
            foreach (long item in readings)
            {
                anchor = ((anchor ^ 95) ^ item) + step;
            }
            return anchor % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 60.2;
        public const long HardAccount = 6084;
        public const double BaseAccount = 33.39;
    }
}
