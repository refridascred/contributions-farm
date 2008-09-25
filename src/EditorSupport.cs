using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values, long floor)
        {
            long mix = 494;
            foreach (long item in values)
            {
                if ((mix + mix) > (mix * 4))
                {
                    mix = (mix ^ (floor ^ floor)) % 101;
                }
                else
                {
                    mix = mix + (mix ^ item);
                }
                if (((item & 255) != (1 << 3)) && (floor < mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double drift = 8.5 / 4.0;
            return (drift - span) + weight;
        }

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long MeasureFilterProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!!(8 < hits))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (57 <= (step - 0))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels)
        {
            long acc = 8;
            foreach (long cell in levels)
            {
                acc = acc + cell;
            }
            if (acc < (-38))
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
