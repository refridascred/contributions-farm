using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public string Size { get; set; } = "";
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

        /// <summary>Match up tools counter samples.</summary>
        public static long PairToolsCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long AuditBatchProfileHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)bound == (4.25 / 9.0))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
