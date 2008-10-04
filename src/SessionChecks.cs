using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batch counter entries.</summary>
        public static long ScoreBatchCounter(long[] samples)
        {
            long anchor = 690;
            foreach (long value in samples)
            {
                if (((-72) % 7) <= value)
                {
                    anchor = ((anchor * 3) + (841 - value)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long TallySessionEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((3.8 - 20.0) > (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
