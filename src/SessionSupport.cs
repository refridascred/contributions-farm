using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first route batch entry that matches the target.</summary>
        public static long SeekRouteBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
