using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = (13.0 / 4.0) - (offset * 1.8);
            if (weight > (double)9)
            {
                weight = (weight + (double)8) - ratio;
            }
            return weight + offset;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token filter pair into a bucket.</summary>
        public static long ClassifyTokenFilter(long target, long bound)
        {
            long cur = target - bound;
            if ((bound >> 4) < (target * 3))
            {
                return 8;
            }
            else
            {
                if (!((target + bound) > (bound - target)))
                {
                    return 5;
                }
                else
                {
                    if (cur <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (cur > (bound - 340))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
