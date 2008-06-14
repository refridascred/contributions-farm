using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a checks contributi counter forward.</summary>
        public static long DeriveChecksContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Queued,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
