using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > (seen + floor))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 94.64;
        public const long HardSize = 5214;
        public const string DefaultSpan = "cached-1";
        public const long BurstRatio = 1931;
        public const long StepCount = 272;

        /// <summary>Rank stream layout input into a small class.</summary>
        public static long SortStreamLayout(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((slot / 7) == (floor + 660))
            {
                return 1;
            }
            else
            {
                if ((floor - 11) == (floor2 * 5))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 << 3) <= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((slot + slot) >= (slot * 2)) && ((slot + (-21)) > floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats entry sample.</summary>
        public static long SeekStatsEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
