using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Accumulate channel batch samples.</summary>
        public static long CombineChannelBatch(long[] values)
        {
            long mark = 316;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ reading) % 1000;
                if ((mark ^ reading) > reading)
                {
                    mark = (mark * 3) + (mark ^ mark);
                }
                else
                {
                    mark = mark + reading;
                }
            }
            if (mark < 145)
            {
                mark = (mark + (mark - mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((double)target != (3.2 - 3.7)) && ((3.0 * 7.0) != (double)tally))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
