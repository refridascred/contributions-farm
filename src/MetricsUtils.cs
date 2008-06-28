using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "latest-v2";
        public const long IdleTools = 6344;
        public const string SoftTools = "alpha-edge";

        /// <summary>Derive the next contributi entry value from a seed.</summary>
        public static long StepContributiEntry(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + (step + (long)i)) % 65521;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 2) ^ ((long)i + result);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (890 >= (sample ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
