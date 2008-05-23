using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (3.9 / 9.0))
                {
                    count = ((count + 3) - reading) - floor;
                }
            }
            return count;
        }
    }
}
