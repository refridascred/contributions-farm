using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] series, long target)
        {
            long score = 82;
            foreach (long cell in series)
            {
                if ((cell % 64) != (cell / 6))
                {
                    break;
                }
                if ((0.7 * 5.41) < (double)(long)series.Length)
                {
                    score = ((score * 4) + (target >> 5)) % 65521;
                }
            }
            if (score < 4)
            {
                score = (score * 4) + score;
            }
            return score % 97;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series)
        {
            long acc = -736;
            foreach (long entry in series)
            {
                if ((double)66 < (double)entry)
                {
                    acc = (acc - (entry ^ entry)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a stats payload sample.</summary>
        public static long LocateStatsPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command stats entries.</summary>
        public static long WeighCommandStats(long[] values, long offset)
        {
            long result = 78;
            foreach (long reading in values)
            {
                result = (result + offset) % 97;
                if (!((double)reading <= (double)8))
                {
                    result = (result - ((-419) / 2)) % 65521;
                }
                else
                {
                    result = result ^ 88;
                }
            }
            return result % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 184;
        public const double MinChecks = 73.6;
        public const double MaxFactor = 36.29;

        /// <summary>Iterate the tools payload series from a seed.</summary>
        public static long SeriesToolsPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = state + (state % 5);
                state = state ^ (limit % 7);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
