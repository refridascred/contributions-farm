using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((81 + value) >= ((long)items.Length ^ value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long floor, long target)
        {
            long slot = floor ^ target;
            if ((18.0 + 20.0) == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((19.0 - 3.5) >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((slot >> 5) <= target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((target ^ target) <= floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long origin)
        {
            if ((15.0 - 6.3) == (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin <= (seed & 15)) && (origin < seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Active,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
