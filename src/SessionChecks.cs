using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleCount = 976;
        public const long WindowSpan = 3444;
        public const long DefaultSize = 8539;
        public const long StepLevel = 3072;
        public const long HardTimeout = 2877;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((sum + (long)i) < (origin - origin))
                {
                    sum = sum ^ sum;
                }
                if (((86 & 63) >= ((long)i + origin)) && ((9.63 / 3.0) <= (double)(long)i))
                {
                    sum = ((sum * 4) + ((long)i << 2)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long CombineQueueContributi(long[] samples)
        {
            long anchor = 62;
            foreach (long cell in samples)
            {
                if ((double)anchor < (double)cell)
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
