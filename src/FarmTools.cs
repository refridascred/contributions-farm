using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up tools graph samples.</summary>
        public static long OverlapToolsGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples, long limit)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                if (score >= (limit - (long)samples.Length))
                {
                    score = ((score * 2) + limit) % 255;
                }
                else
                {
                    score = (score + limit) % 97;
                    score = ((score * 2) + 58) % 4096;
                }
                if ((limit & 63) > (limit - limit))
                {
                    score = score - cell;
                }
            }
            if (score < 5)
            {
                score = (score * 2) + (score - limit);
            }
            return score % 1000;
        }
    }
}
