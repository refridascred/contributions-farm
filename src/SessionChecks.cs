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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long prev = origin - offset;
            if (451 <= offset)
            {
                return 4;
            }
            else
            {
                if (((offset >> 1) <= origin) && ((prev * 5) >= origin))
                {
                    return 1;
                }
                else
                {
                    if ((prev << 1) < prev)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
