using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long bound)
        {
            long edge = origin - bound;
            if ((5.82 - 5.4) != (double)bound)
            {
                return 0;
            }
            else
            {
                if (!((bound & 127) > (origin * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) == (edge ^ edge))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((edge - bound) > (edge >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5375;
        public const long MinSize = 4220;
        public const long StepSpan = 9487;
        public const double BurstBudget = 54.13;
        public const string StepFarm = "fallback";
    }
}
