using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long DigestBufferStats(long[] items, long offset)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (((14.0 + 2.37) != (double)cell) && ((8.2 * 9.0) < (double)cell))
                {
                    sum = ((sum << 3) ^ (9 << 2)) % 4096;
                }
                else
                {
                    sum = (sum - (cell & 7)) % 255;
                }
                if ((offset + sum) >= (cell - (-980)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ (sum << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Stale,
            Active,
            Queued,
            Paused,
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long bound)
        {
            if ((double)target > 4.38)
            {
                return 7;
            }
            else
            {
                if (target > (bound >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((20 < (bound % 2)) && ((target << 3) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Paused,
            Stale,
            Draft,
        }
    }
}
