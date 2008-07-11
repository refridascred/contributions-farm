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

        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long LookupChannelBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double scale = (double)(1 - (-423));
            if (scale < (double)0)
            {
                scale = (scale - (ratio - ratio)) - bias;
            }
            return scale - (ratio / 5.0);
        }
    }
}
