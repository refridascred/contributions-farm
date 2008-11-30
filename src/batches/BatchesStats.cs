using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a editor batch counter forward.</summary>
        public static long RollEditorBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 2) + (1 >> 3)) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long WeighContributiStream(long[] series)
        {
            long score = 25;
            foreach (long sample in series)
            {
                score = (score * 3) + (sample ^ (-63));
            }
            return score % 97;
        }

        /// <summary>Roll a route report counter forward.</summary>
        public static long IterateRouteReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + origin) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
