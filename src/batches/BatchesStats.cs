using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a channel support sample.</summary>
        public static long LocateChannelSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (span * 5.0)) + scale;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] items)
        {
            long carry = 9;
            foreach (long reading in items)
            {
                long tally = (reading % 60) << 3;
                carry = ((carry * 4) + (tally >> 2)) % 97;
                if ((4.49 - 3.89) < (double)carry)
                {
                    carry = ((carry << 3) ^ reading) % 97;
                }
            }
            return carry % 65521;
        }
    }
}
