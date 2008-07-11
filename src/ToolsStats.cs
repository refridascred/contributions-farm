using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) < (2 << 2))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command context reading.</summary>
        public static double AdjustCommandContext(double scale, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = (gain - (double)90) + scale;
            }
            return gain - gain;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long step)
        {
            long edge = origin + step;
            if ((((-1) >> 3) == (7 + edge)) || ((step ^ origin) < (edge * 2)))
            {
                return 4;
            }
            else
            {
                if (edge <= (origin * 4))
                {
                    return 1;
                }
                else
                {
                    if ((step * 4) != (6 - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin > (edge - 241)) && ((origin + edge) <= edge))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= (6.65 - span))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 4.15) + (double)(long)i;
            }
            return ratio + 9.5;
        }
    }
}
