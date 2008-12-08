using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cluster already entries.</summary>
        public static long TallyClusterAlready(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                carry = carry + (entry >> 1);
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 8944;
        public const long MinSpan = 2852;
        public const long MaxFactor = 7095;

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - target) >= (matches ^ matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
