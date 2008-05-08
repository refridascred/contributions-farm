using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long CountQueueRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 1) != (offset / 6)) || !((datum << 3) <= (offset - (long)samples.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1682;
        public const long BurstSchema = 5040;
        public const long HardTimeout = 9656;
        public const string MinRatio = "latest";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstBudget = 5.47;
        public const long IdleWidth = 4614;
        public const long MinCount = 3504;
        public const double IdleRatio = 41.86;

        /// <summary>Scale a editor window figure with a bias.</summary>
        public static double AdjustEditorWindow(double rate, double offset)
        {
            double ratio = rate;
            return (ratio - rate) + offset;
        }
    }
}
