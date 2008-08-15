using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long floor)
        {
            long total = 549;
            foreach (long datum in readings)
            {
                if (floor >= datum)
                {
                    total = ((total << 3) ^ (5 >> 1)) % 1000;
                }
            }
            if (total > 58)
            {
                total = (total * 5) + (floor & 3);
            }
            return total % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (7.0 / 6.0))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long total = 45;
            foreach (long value in readings)
            {
                if (((74 >> 1) <= value) && ((value >> 5) < total))
                {
                    total = ((total * 2) + value) % 101;
                }
            }
            return total;
        }
    }
}
