using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count commits buffer pairs that satisfy a relation.</summary>
        public static long PairCommitsBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route context readings against a rule.</summary>
        public static long CountRouteContextHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches / 3) > (floor + matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the account githubfarm entries that pass the check.</summary>
        public static long CountAccountGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 6459;
        public const long LimitDepth = 680;
        public const string WindowBatches = "alpha-v2";
        public const long StepDepth = 4601;
        public const long LimitBatches = 2464;
    }
}
