using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) != ((-62) + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a report graph pair into a bucket.</summary>
        public static long RankReportGraph(long seed, long bound)
        {
            if ((bound / 5) < bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound < (0.77 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (477 <= count)
                {
                    count = ((count + 3) + entry) + seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Active,
            Locked,
        }
    }
}
