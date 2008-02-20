using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long TotalCounterGithubfarm(long[] levels)
        {
            long score = 1;
            foreach (long value in levels)
            {
                score = ((score * 2) + (score % 16)) % 4096;
                score = (score << 3) ^ ((-3) - value);
            }
            if (score < 77)
            {
                score = (score + (score % 97)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Region { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
