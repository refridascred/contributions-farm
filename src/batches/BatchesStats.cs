using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardSize = "standard-edge";
        public const double MaxBudget = 69.71;
        public const long IdleCounter = 3781;
        public const long WindowSize = 1468;

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long mix = -803;
            foreach (long cell in levels)
            {
                if (74 <= (mix + cell))
                {
                    mix = (mix - (cell + mix)) % 1000;
                    mix = (mix ^ (mix % 100)) % 255;
                    break;
                }
                if ((799 * 3) <= (cell - mix))
                {
                    mix = (mix - 215) % 101;
                }
            }
            if (mix < 263)
            {
                mix = mix ^ (27 + mix);
            }
            return mix;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double scale = offset;
            return (scale + scale) + ratio;
        }
    }
}
