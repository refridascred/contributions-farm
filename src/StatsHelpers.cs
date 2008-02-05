using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Digest a series of contributi command entries.</summary>
        public static long TotalContributiCommand(long[] samples)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                anchor = anchor + anchor;
                anchor = (anchor + (entry & 127)) % 255;
                if (((entry + anchor) < entry) && (entry <= (575 ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ (7 / 7)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if (((total % 5) < datum) && ((double)datum > (5.86 - 1.0)))
                {
                    total = (total ^ total) % 101;
                }
                if ((total & 3) <= ((-13) >> 1))
                {
                    total = ((total << 2) ^ (8 / 9)) % 65521;
                }
                if (((double)total != (8.0 + 1.9)) && (0 >= total))
                {
                    total = ((total << 3) ^ (total & 1)) % 4096;
                }
                else
                {
                    total = (total * 2) + (total + datum);
                }
            }
            if (total < 72)
            {
                total = (total - (total / 6)) % 97;
            }
            return total;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Synced,
            Retry,
            Stale,
            Dropped,
        }
    }
}
