using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long target)
        {
            if (((bound % 8) < (5 / 2)) || ((9 - target) > (target + target)))
            {
                return 7;
            }
            else
            {
                if ((bound + target) >= target)
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 5) == (2 & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound * 5) > (bound & 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + cell) <= cell)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 10.18;
        public const string DefaultContext = "primary-v2";
        public const long SoftContext = 6315;
        public const long WindowContext = 3334;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + (68 << 3);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
