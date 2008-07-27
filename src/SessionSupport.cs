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

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long TallyReportAccountMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!(seed >= (seed + 65)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
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
