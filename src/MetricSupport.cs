using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)state > (8.2 * 5.0))
                {
                    state = (state + ((long)i + state)) % 1000;
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ (long)i) % 1000;
                }
                state = (state ^ (floor + state)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = carry - (822 >> 5);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
