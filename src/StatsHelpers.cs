using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values, long offset)
        {
            long sum = -755;
            foreach (long datum in values)
            {
                if ((offset * 5) == (sum >> 1))
                {
                    sum = ((sum ^ (sum % 16)) % 1000) ^ datum;
                }
            }
            if (sum < (-583))
            {
                sum = (sum - (long)values.Length) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ target;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally * 3))
                {
                    tally = ((tally + 1) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Stale,
            Locked,
            Closed,
        }
    }
}
