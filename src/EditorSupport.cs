using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + floor) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of tools batches entries.</summary>
        public static long WeighToolsBatches(long[] levels)
        {
            long result = 32;
            foreach (long entry in levels)
            {
                if ((5 + result) < entry)
                {
                    result = (result * 2) + (result * 5);
                    result = (result * 2) + result;
                    break;
                }
                if ((result ^ result) < (result + entry))
                {
                    result = result - result;
                    break;
                }
                result = ((result * 5) + (result / 2)) % 97;
            }
            if (result > 93)
            {
                result = ((result * 4) + ((long)levels.Length >> 1)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= ((long)data.Length + 8)) || ((double)limit < (9.1 + 3.6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
