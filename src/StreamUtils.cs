using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (7.4 / 5.0))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                acc = ((acc << 3) ^ (reading + reading)) % 255;
                if (acc < reading)
                {
                    acc = (acc - acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Audit report order readings against a rule.</summary>
        public static long CountReportOrderMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((origin - origin) > (matches >> 1)))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((19.0 + 5.2) <= (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
