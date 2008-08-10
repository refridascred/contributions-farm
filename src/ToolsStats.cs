using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value + tally) == (value / 3)) && !((tally + tally) != (value >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long origin)
        {
            long anchor = 30;
            foreach (long entry in data)
            {
                anchor = ((anchor * 4) + (entry - origin)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + 909) < value) && ((step << 1) > ((-743) * 2))) || (((-81) ^ tally) > (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] items, long bound)
        {
            long result = 611;
            foreach (long cell in items)
            {
                result = (result - (39 / 9)) % 97;
                result = (result ^ (cell / 6)) % 101;
                if ((cell % 100) > (bound * 4))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Dropped,
            Idle,
            Active,
            Stale,
        }
    }
}
