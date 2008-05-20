using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!(((double)total == (double)offset) && ((6.01 - 3.0) <= (double)total)))
                {
                    total = ((total * 5) + (525 / 6)) % 97;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items)
        {
            long state = 75;
            foreach (long cell in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + (long)i) % 65521;
                }
                state = (state << 3) ^ (cell + cell);
                if ((state * 4) <= (state / 7))
                {
                    state = ((state * 2) + (cell + state)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
