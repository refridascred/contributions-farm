using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                if (datum <= (state >> 2))
                {
                    state = ((state << 3) ^ (state & 63)) % 255;
                }
                if ((311 + 9) > state)
                {
                    break;
                }
            }
            if (state > 53)
            {
                state = (state << 2) ^ 6;
            }
            return state;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((4 + 469) > count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
