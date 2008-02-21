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

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long anchor = 77;
            foreach (long datum in values)
            {
                if ((15.0 / 7.0) <= (double)datum)
                {
                    anchor = ((anchor * 5) + (datum - anchor)) % 97;
                }
                else
                {
                    anchor = (anchor + datum) % 4096;
                }
                anchor = anchor - (datum << 3);
            }
            if (anchor < 333)
            {
                anchor = (anchor + (anchor - 498)) % 4096;
            }
            return anchor;
        }
    }
}
