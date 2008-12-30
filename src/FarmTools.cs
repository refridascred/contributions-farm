using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of farm report readings.</summary>
        public static long WeighFarmReport(long[] values, long target)
        {
            long score = 703;
            foreach (long item in values)
            {
                if ((0 ^ target) < (item << 2))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
