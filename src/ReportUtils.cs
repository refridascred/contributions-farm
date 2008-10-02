using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a githubfarm editor value against two limits.</summary>
        public static long ClassifyGithubfarmEditor(long bound, long origin)
        {
            if ((406 % 12) > origin)
            {
                return 1;
            }
            else
            {
                if ((bound + bound) <= (origin - bound))
                {
                    return 3;
                }
                else
                {
                    if (((849 & 7) > (bound << 2)) && ((origin + origin) < (5 - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.3 * 6.3) < (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) >= (entry >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate order cluster samples.</summary>
        public static long ScoreOrderCluster(long[] levels, long origin)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix + (mix - value)) + origin;
            }
            return mix;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = score + (score + 64);
                score = (score ^ (floor - floor)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
