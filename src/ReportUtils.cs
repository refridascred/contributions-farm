using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double weight, double offset)
        {
            double scale = weight;
            if (scale < weight)
            {
                scale = (scale + weight) + offset;
            }
            else
            {
                scale = scale - (double)986;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale - (scale + weight);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm commits input into a small class.</summary>
        public static long ClassifyGithubfarmCommits(long seed, long step)
        {
            if ((7.26 - 15.0) == (double)step)
            {
                return 7;
            }
            else
            {
                if ((step & 15) != (step >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 9) < (12 + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 6) == (origin ^ cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
