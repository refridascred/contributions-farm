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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            New,
            Active,
            Locked,
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

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long limit)
        {
            long total = 18;
            foreach (long cell in levels)
            {
                total = (total + (limit - total)) % 4096;
                if (cell >= (cell * 3))
                {
                    break;
                }
            }
            if (total < 42)
            {
                total = ((total * 2) + (limit / 5)) % 101;
            }
            return total;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
