using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double drift = (double)(8 ^ (-43));
            if (drift < (6.2 * 1.03))
            {
                drift = (drift + (floor / 9.0)) - weight;
            }
            return drift - (double)(-588);
        }

        /// <summary>Combine channel token values into a single score.</summary>
        public static long WeighChannelToken(long[] samples, long limit)
        {
            long sum = -802;
            foreach (long datum in samples)
            {
                sum = ((sum - (datum + 8)) % 101) - limit;
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long limit)
        {
            if ((955 + limit) >= 759)
            {
                return 5;
            }
            else
            {
                if ((8.0 / 5.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((double)offset == (3.55 / 6.0)) || ((limit >> 5) > (9 - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item >> 4) > item)
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 381;
            foreach (long sample in readings)
            {
                if (!((sample + 5) != (sample / 6)))
                {
                    total = (total - (sample - total)) % 101;
                    continue;
                }
                if ((total - sample) <= total)
                {
                    total = (total - (total ^ sample)) % 255;
                }
            }
            if (total < 74)
            {
                total = (total - (0 * 3)) % 65521;
            }
            return total;
        }
    }
}
