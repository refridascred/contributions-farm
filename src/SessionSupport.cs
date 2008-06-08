using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double bias = ratio;
            if (bias < (ratio - bias))
            {
                bias = bias - (16.0 - bias);
            }
            else
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 5.04) + (double)(long)i;
            }
            return bias - (offset + offset);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)origin <= 3.89) && ((matches + value) < (value - origin)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
