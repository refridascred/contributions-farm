using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + 850) != (tally / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a filter profile reading by value.</summary>
        public static long SeekFilterProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((origin <= (origin & 127)) && ((value / 3) >= (origin + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long FoldFarmQueue(long[] readings)
        {
            long result = 42;
            foreach (long value in readings)
            {
                if ((value + 755) >= (result * 4))
                {
                    result = (result << 2) ^ (result << 2);
                }
            }
            if (result > 33)
            {
                result = (result + (69 % 97)) % 255;
            }
            return result;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell * 3) >= (matches ^ cell)) || (cell >= (cell % 7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
