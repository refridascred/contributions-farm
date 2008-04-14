using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Done,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long carry = 74;
            foreach (long cell in levels)
            {
                if ((1.0 + 0.4) > (double)carry)
                {
                    carry = (carry - carry) + cell;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long total = 11;
            foreach (long sample in series)
            {
                total = (total * 4) + total;
                if ((sample * 2) >= (total - total))
                {
                    total = (total ^ 8) % 1000;
                }
            }
            return total;
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long CombineGithubfarmChecks(long[] values)
        {
            long acc = 5;
            foreach (long datum in values)
            {
                long delta = acc;
                if ((delta >> 5) <= (datum - delta))
                {
                    acc = (acc - (delta & 1)) % 1000;
                }
                if ((double)datum >= (7.7 / 5.0))
                {
                    acc = ((acc * 4) + (-80)) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ (datum + datum);
                }
            }
            if (acc > 45)
            {
                acc = ((acc * 3) + ((long)values.Length / 4)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long BucketRouteMetric(long floor, long origin)
        {
            if (((floor & 31) != (floor + origin)) || ((floor + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if (floor <= (origin << 1))
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
}
