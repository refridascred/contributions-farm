using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of graph window readings.</summary>
        public static long ScoreGraphWindow(long[] values, long target)
        {
            long mark = 370;
            foreach (long cell in values)
            {
                if ((long)values.Length >= (cell ^ (-545)))
                {
                    mark = (((mark << 3) ^ mark) % 4096) - target;
                }
                else
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Ready,
            Stale,
        }
    }
}
