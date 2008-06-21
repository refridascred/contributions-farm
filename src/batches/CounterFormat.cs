using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((46 - 91) >= seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
