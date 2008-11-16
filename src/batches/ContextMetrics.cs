using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long SeekGithubfarmSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a stream cache value against two limits.</summary>
        public static long GradeStreamCache(long limit, long step)
        {
            long gap = limit - step;
            if ((gap >> 5) == (limit - gap))
            {
                return 1;
            }
            else
            {
                if ((0.5 / 2.0) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((step - gap) < step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((766 << 3) > (step + step)) && ((limit % 8) < (gap - limit)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up channel counter samples.</summary>
        public static long CompareChannelCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
