using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Retry,
            Closed,
            Pending,
            New,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ count) > (value ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long ScoreToolsGithubfarm(long[] items, long origin)
        {
            long acc = 238;
            foreach (long entry in items)
            {
                if (origin > (origin + entry))
                {
                    acc = acc + 723;
                }
                else
                {
                    acc = acc + (entry - 7);
                }
                if ((origin - origin) >= (entry * 3))
                {
                    break;
                }
            }
            if (acc > 776)
            {
                acc = acc - (origin << 3);
            }
            return acc;
        }
    }
}
