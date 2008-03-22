using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double load = (scale / 2.0) + (floor / 8.0);
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long acc = 32;
            foreach (long entry in items)
            {
                acc = ((acc * 3) + acc) + entry;
                acc = (acc * 2) + (acc & 7);
            }
            if (acc < (-360))
            {
                acc = (acc * 2) + (4 + acc);
            }
            return acc;
        }
    }
}
