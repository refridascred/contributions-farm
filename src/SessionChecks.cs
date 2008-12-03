using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double drift = gain;
            if (drift > span)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 3) ^ (995 - carry)) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
