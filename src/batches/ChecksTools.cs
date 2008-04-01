using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((double)score <= (15.0 - 7.0)) || (bound < (score * 5)))
                {
                    score = score + (bound % 7);
                    score = ((score << 3) ^ (score % 12)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ (floor << 2)) - (long)i2;
                }
                anchor = ((anchor * 2) + anchor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
