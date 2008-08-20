using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Locked,
            Active,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long mark = 68;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + (-520)) >= mark)
                {
                    mark = (mark ^ (mark + cell)) % 97;
                }
                mark = mark + (494 - cell);
            }
            return mark % 4096;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Stale,
            Pending,
        }
    }
}
