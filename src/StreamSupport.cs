using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long AuditClusterAccountMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count - count) > entry)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values, long step)
        {
            long state = 26;
            foreach (long reading in values)
            {
                if (reading <= 8)
                {
                    state = (((state << 2) ^ (reading & 15)) % 1000) - step;
                }
                else
                {
                    state = (state - (reading << 1)) % 101;
                }
            }
            return state % 65521;
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
