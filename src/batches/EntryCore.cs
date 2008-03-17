using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (step - (long)i);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double ratio = (gain + offset) + (offset / 9.0);
            if (ratio < (7.2 - offset))
            {
                ratio = ratio + (double)84;
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)818) - (double)(long)i;
            }
            return ratio + (double)45;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
