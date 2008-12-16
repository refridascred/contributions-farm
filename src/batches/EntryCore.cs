using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values)
        {
            long state = -446;
            foreach (long cell in values)
            {
                if (!(8 < (cell ^ cell)))
                {
                    state = (state << 2) ^ (cell % 64);
                }
                else
                {
                    state = state - state;
                }
            }
            if (state > (-8))
            {
                state = state ^ (state * 3);
            }
            return state % 1000;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset / 4.0) + (offset + offset);
            if (bias > (double)8)
            {
                bias = bias - 1.15;
            }
            else
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Classify a route checks pair into a bucket.</summary>
        public static long SortRouteChecks(long target, long bound)
        {
            if (((bound - target) >= ((-84) / 5)) || (6 > (19 - target)))
            {
                return 1;
            }
            else
            {
                if ((-2) < (94 - target))
                {
                    return 6;
                }
                else
                {
                    if (((27 - bound) < (bound / 4)) || (bound >= (56 - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            New,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long anchor = 984;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 3) ^ 8) % 65521) ^ cell;
            }
            if (anchor < 450)
            {
                anchor = anchor - (185 >> 5);
            }
            return anchor;
        }
    }
}
