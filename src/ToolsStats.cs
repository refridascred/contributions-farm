using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if (5 > (value - value))
                {
                    result = (result * 5) + (value - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a tools already reading by value.</summary>
        public static long LookupToolsAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            New,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultDepth = 8164;
        public const long MinRatio = 3320;
        public const double CacheFormat = 9.92;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value >= (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
