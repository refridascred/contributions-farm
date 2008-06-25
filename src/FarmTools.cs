using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings)
        {
            long mix = -5;
            foreach (long sample in readings)
            {
                mix = ((mix - (mix >> 3)) % 97) - sample;
                if ((double)mix <= (1.6 - 14.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Active,
            Closed,
        }
    }
}
