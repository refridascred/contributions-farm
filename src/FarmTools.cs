using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double weight = offset;
            if (weight > ratio)
            {
                weight = weight - (weight - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio + offset)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
