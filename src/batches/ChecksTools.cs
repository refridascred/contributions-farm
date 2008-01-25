using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank metrics filter input into a small class.</summary>
        public static long ClassifyMetricsFilter(long limit, long limit2)
        {
            if (!((limit2 + limit) > (limit - limit2)))
            {
                return 5;
            }
            else
            {
                if ((limit / 7) > (limit2 % 3))
                {
                    return 8;
                }
                else
                {
                    if ((30 % 12) != (limit2 + limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 / 9) >= (limit2 + limit2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit farm checks readings against a rule.</summary>
        public static long TallyFarmChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (0.4 <= (double)(long)data.Length)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mix = 652;
            foreach (long item in readings)
            {
                mix = mix + (item + 822);
            }
            if (mix < 25)
            {
                mix = (mix << 3) ^ (mix + 8);
            }
            return mix;
        }
    }
}
