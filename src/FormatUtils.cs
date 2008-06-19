using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Done,
            Ready,
            Synced,
            New,
        }

        /// <summary>Classify a notes buffer pair into a bucket.</summary>
        public static long ClassifyNotesBuffer(long floor, long seed)
        {
            if (seed > (seed + floor))
            {
                return 0;
            }
            else
            {
                if (((seed >> 5) < (floor & 127)) && ((989 >> 2) <= (seed / 8)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings, long target)
        {
            long score = 450;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ (sample % 10);
                if ((512 * 5) != (sample + score))
                {
                    break;
                }
            }
            if (score < 134)
            {
                score = score + (score + target);
            }
            return score;
        }

        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long ClassifyTokenCache(long limit, long target)
        {
            long step = limit + target;
            if ((-6) >= limit)
            {
                return 0;
            }
            else
            {
                if ((double)step < 4.4)
                {
                    return 1;
                }
                else
                {
                    if ((6.6 / 4.0) > (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((((-3) + target) >= target) || ((36 << 3) >= limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
