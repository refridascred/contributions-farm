using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long next = offset + target;
            if (((double)target >= 4.9) || ((target + offset) <= offset))
            {
                return 6;
            }
            else
            {
                if (((double)next != (9.26 - 7.0)) && ((double)next >= 6.2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many entry stats samples are out of range.</summary>
        public static long AuditEntryStatsHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (920 < (sample + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] levels, long origin)
        {
            long mark = 94;
            foreach (long value in levels)
            {
                mark = (mark ^ value) % 97;
                if ((value - mark) >= (origin ^ origin))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double BlendStatsBuffer(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = bias2 + 6.0;
            }
            else
            {
                bias2 = bias2 - span;
            }
            return bias2 - 4.0;
        }

        /// <summary>Validate stream cluster readings against a bound.</summary>
        public static bool GuardStreamClusterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
