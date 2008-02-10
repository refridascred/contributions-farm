using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long TallyStreamSessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell < (777 << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long state = 259;
            foreach (long item in series)
            {
                if (((7.0 - 3.2) < (double)state) && ((step + 83) > item))
                {
                    state = state + (step + step);
                }
            }
            return state % 97;
        }

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long DigestFormatCluster(long[] readings, long seed)
        {
            long sum = -11;
            foreach (long cell in readings)
            {
                sum = (sum + cell) % 255;
                sum = (sum + 243) % 97;
            }
            if (sum < 7)
            {
                sum = (sum + (9 + seed)) % 97;
            }
            return sum % 97;
        }
    }
}
