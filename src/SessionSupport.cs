using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((4.0 * 6.1) < (double)step)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }
    }
}
