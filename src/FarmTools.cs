using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) > (count + step))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long item in samples)
            {
                if (78 <= (sum * 3))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if ((double)bound <= (2.8 - 7.0))
                {
                    sum = ((sum << 3) ^ (997 + bound)) % 1000;
                }
                if ((sum + bound) >= (sum + item))
                {
                    break;
                }
            }
            if (sum < (-124))
            {
                sum = ((sum * 2) + bound) % 1000;
            }
            return sum;
        }
    }
}
