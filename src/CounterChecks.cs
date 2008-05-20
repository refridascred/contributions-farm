using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long acc = -4;
            foreach (long entry in series)
            {
                if ((double)acc <= (6.91 - 6.3))
                {
                    acc = (acc + (0 + entry)) % 255;
                }
                else
                {
                    acc = (acc - (entry % 2)) % 255;
                }
            }
            if (acc < (-1))
            {
                acc = acc ^ (271 + 9);
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count << 2) > 42))
                {
                    count = ((count + 2) + cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long sum = 517;
            foreach (long reading in levels)
            {
                if ((floor - floor) > reading)
                {
                    sum = (sum - (floor << 3)) % 97;
                }
            }
            if (sum < 132)
            {
                sum = ((sum << 2) ^ (sum / 6)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstRatio = 7520;
        public const long MaxCount = 3809;
        public const string CacheInterval = "stable";

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long SeekGraphGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
