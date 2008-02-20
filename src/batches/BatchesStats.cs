using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long MeasureProfileCommandGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((8 + tally) > (reading - 2))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Look up the position of a entry tools sample.</summary>
        public static long LookupEntryToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels, long floor)
        {
            long result = 240;
            foreach (long reading in levels)
            {
                result = (((result ^ (80 - 886)) % 4096) ^ reading) + floor;
            }
            return result;
        }
    }
}
