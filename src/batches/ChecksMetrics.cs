using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Paused,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long floor)
        {
            long anchor = 22;
            foreach (long cell in levels)
            {
                if ((53 + cell) < (anchor % 2))
                {
                    anchor = (anchor - ((long)levels.Length / 5)) + floor;
                }
            }
            if (anchor < (-34))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Match up profile order samples.</summary>
        public static long OverlapProfileOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
