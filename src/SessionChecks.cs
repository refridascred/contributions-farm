using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long target)
        {
            if ((target + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (1.0 * 5.5))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (-1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many farm editor samples are out of range.</summary>
        public static long MeasureFarmEditorMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell - 995) <= count) || ((16.0 - 5.46) != (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
