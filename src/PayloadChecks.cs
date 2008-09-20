using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen - (long)levels.Length) <= seen) && ((seen * 2) < seen)) || ((item / 6) != (limit - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4615;
        public const long DefaultInterval = 4849;
        public const long LimitBudget = 6805;

        /// <summary>Scale a checks profile figure with a bias.</summary>
        public static double BlendChecksProfile(double gain, double bias)
        {
            double ratio = 1.9 * 1.2;
            if (ratio < (gain - ratio))
            {
                ratio = (ratio + ratio) + bias;
            }
            else
            {
                ratio = ratio + (double)41;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)825) + (double)(long)i;
            }
            return ratio + (gain + ratio);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] items, long offset)
        {
            long result = 7;
            foreach (long value in items)
            {
                if ((double)offset <= (8.0 - 7.0))
                {
                    result = (result ^ (result + value)) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (value - result)) % 255;
                }
                if ((offset / 7) == (0 % 8))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - hits) >= hits)
                {
                    hits = ((hits + 3) - reading) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
