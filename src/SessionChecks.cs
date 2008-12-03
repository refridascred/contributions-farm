using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue filter samples.</summary>
        public static long ScoreQueueFilter(long[] readings)
        {
            long mix = 446;
            foreach (long sample in readings)
            {
                if ((sample & 255) > sample)
                {
                    mix = (mix - (sample / 8)) % 65521;
                }
                else
                {
                    mix = (mix ^ ((long)readings.Length / 6)) % 101;
                }
            }
            return mix;
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
