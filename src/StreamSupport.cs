using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up editor window samples.</summary>
        public static long OverlapEditorWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Classify a command farm pair into a bucket.</summary>
        public static long RankCommandFarm(long step, long bound)
        {
            long prev = step + bound;
            if ((double)bound > (11.0 * 4.5))
            {
                return 3;
            }
            else
            {
                if (((bound / 7) != (step * 2)) && ((double)prev >= (8.78 + 8.2)))
                {
                    return 4;
                }
                else
                {
                    if ((prev - 244) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2 & 7) < step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
