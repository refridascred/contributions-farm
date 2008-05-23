using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings)
        {
            long mark = -2;
            foreach (long cell in readings)
            {
                if ((mark - 0) >= (cell + cell))
                {
                    mark = (mark - (cell - mark)) % 97;
                }
                if (1.53 < (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a contributi cluster counter forward.</summary>
        public static long IterateContributiCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((target * 3) == (carry - target)))
                {
                    break;
                }
                carry = ((carry * 2) + carry) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate queue editor samples.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long carry = 11;
            foreach (long value in values)
            {
                carry = (carry - (value << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample < (33 * 5))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
