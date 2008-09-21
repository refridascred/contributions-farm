using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit session account readings against a rule.</summary>
        public static long MeasureSessionAccountHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((864 * 2) >= (value << 3)) && ((value - tally) != (56 + 800)))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long target)
        {
            long slot = floor ^ target;
            if (14.0 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((slot & 63) < (-50))
                {
                    return 6;
                }
                else
                {
                    if ((target & 3) > (slot - 67))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((slot + target) < (slot / 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8164;
        public const long BurstSupport = 8656;
        public const long BatchRatio = 4964;
        public const long HardSupport = 3426;
    }
}
