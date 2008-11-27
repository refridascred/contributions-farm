using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((seed < sample) && ((seed ^ 27) > (sample + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
