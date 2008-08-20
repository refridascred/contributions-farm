using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of already tools readings.</summary>
        public static long MatchAlreadyToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count == (1.81 - 2.0))
                {
                    count = ((count + 2) + datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long origin)
        {
            if (((double)offset < (double)origin) && ((offset + origin) <= (156 - origin)))
            {
                return 8;
            }
            else
            {
                if ((origin > (origin << 3)) || ((offset + origin) < 44))
                {
                    return 2;
                }
                else
                {
                    if (((origin - origin) <= (origin - offset)) || ((origin + origin) > (origin - origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 5788;
        public const string MinChannel = "fallback";
        public const long BatchChannel = 1861;
        public const long DefaultChannel = 6802;
    }
}
