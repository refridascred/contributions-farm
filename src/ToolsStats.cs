using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Paused,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6270;
        public const long MaxFactor = 8681;
        public const long StepLayout = 4624;
        public const double StepSpan = 31.65;
        public const double BaseLayout = 22.87;

        /// <summary>Find the first graph report entry that matches the target.</summary>
        public static long SeekGraphReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - value) == (value >> 1))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
