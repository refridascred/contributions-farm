using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample - (long)samples.Length) > (sample ^ sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((324 & 127) < (cell + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
