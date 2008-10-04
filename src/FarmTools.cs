using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double ratio = (double)54 - span;
            if (ratio <= (weight - 12.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 0.17) + (double)(long)i;
            }
            return ratio - (12.0 + weight);
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
