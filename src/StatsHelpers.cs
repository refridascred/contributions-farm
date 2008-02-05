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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (9.4 < (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i + acc)) % 255;
                }
                if (!(step > (acc - (long)i)))
                {
                    acc = acc - step;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
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
