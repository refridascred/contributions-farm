using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ carry) % 97;
                carry = (carry - (limit << 3)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long MeasureRecordStatsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell << 2) > (cell % 10)) || ((6.9 - 2.0) <= 5.0))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Measure how many session route samples are out of range.</summary>
        public static long CountSessionRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((((long)levels.Length - 39) >= cell) && ((tally & 7) < (387 + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 101;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
