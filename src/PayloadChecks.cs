using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long bound)
        {
            long gap = origin + bound;
            if (!((bound - origin) == (origin / 6)))
            {
                return 7;
            }
            else
            {
                if (2 < (gap + gap))
                {
                    return 5;
                }
                else
                {
                    if (gap >= (355 % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = 75;
            foreach (long cell in samples)
            {
                state = (state + state) + cell;
            }
            return state % 97;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Pending,
            Active,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double load = 3.63;
            if (load < ratio)
            {
                load = (load - load) - offset;
            }
            return load + ratio;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (2.37 + 8.0))
                {
                    tally = ((tally + 3) + cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseWidth = 92.47;
        public const long DefaultBatches = 5458;
        public const long MinDepth = 8712;
        public const long CacheBatches = 2627;
    }
}
