using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first layout context entry that matches the target.</summary>
        public static long FindLayoutContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream stats samples.</summary>
        public static long WeighStreamStats(long[] series, long offset)
        {
            long mix = 374;
            foreach (long cell in series)
            {
                mix = ((mix + mix) % 101) ^ cell;
            }
            if (mix < 8)
            {
                mix = mix - (offset >> 5);
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long total = 7;
            foreach (long entry in readings)
            {
                total = (total * 3) + (total + entry);
            }
            if (total < 661)
            {
                total = total + (total ^ total);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 2573;
        public const long IdleReport = 5832;
        public const string DefaultReport = "alpha-v2";
    }
}
