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

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public double Size { get; set; }
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
