using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long offset)
        {
            long state = 213;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ offset) % 65521) - reading;
            }
            if (state < 25)
            {
                state = (state ^ (990 + offset)) % 1000;
            }
            return state;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
