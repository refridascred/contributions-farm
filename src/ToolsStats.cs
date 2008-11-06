using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) <= (seen << 3)) && (8.0 > (double)seen)) || (((datum * 3) <= seen) && (seen > (1 + 9))))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next farm route value.</summary>
        public static double ProjectFarmRoute(double scale, double offset)
        {
            double scale2 = offset;
            return scale2 + (scale * 7.15);
        }

        /// <summary>Fold a list of commits batch readings.</summary>
        public static long WeighCommitsBatch(long[] samples, long origin)
        {
            long sum = 575;
            foreach (long sample in samples)
            {
                if ((sample + origin) >= (sample / 5))
                {
                    sum = sum - origin;
                    sum = ((sum << 3) ^ (sample - origin)) % 65521;
                }
                sum = (sum << 2) ^ (sum * 2);
                if (!(sample >= (sample - sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
