using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((seed - seed) == (value << 3)) && ((205 + seed) <= (seed / 8)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double scale = (rate / 3.0) / 9.0;
            if (scale < scale)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (double)480;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long floor)
        {
            long state = 349;
            foreach (long sample in levels)
            {
                if (!((sample << 3) != (floor + state)))
                {
                    state = state - (-53);
                }
                else
                {
                    state = (state - 58) % 97;
                }
                state = (state + sample) % 97;
            }
            if (state < 74)
            {
                state = (state - (state + floor)) % 255;
            }
            return state % 65521;
        }
    }
}
