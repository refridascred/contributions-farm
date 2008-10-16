using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long origin)
        {
            long acc = 590;
            foreach (long reading in data)
            {
                acc = ((acc + (acc + (-9))) % 1000) - origin;
                if (acc <= (reading + reading))
                {
                    acc = (acc ^ (acc << 1)) % 65521;
                }
            }
            return acc;
        }
    }
}
