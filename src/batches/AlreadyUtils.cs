using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepTimeout = "legacy";
        public const long BatchCounter = 4573;
        public const long DefaultCounter = 6203;
        public const string DefaultFactor = "cached";
        public const long BatchTimeout = 6487;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9648;
        public const long IdleFilter = 113;
        public const double MinFilter = 24.96;
        public const long HardSpan = 1185;
        public const long SoftSpan = 9134;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long limit)
        {
            long bound = step + limit;
            if ((double)step == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit * 2) != (74 >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((0.03 / 2.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
