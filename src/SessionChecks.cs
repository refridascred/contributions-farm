using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Done,
            Queued,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long carry = 243;
            foreach (long sample in items)
            {
                if ((18 % 16) >= (carry + 616))
                {
                    carry = ((carry << 2) ^ (sample - carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
