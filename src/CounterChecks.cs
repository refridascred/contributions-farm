using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((7 - datum) > (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 1) >= (tally + entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer record value from a seed.</summary>
        public static long StepBufferRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                if (!(1.58 <= (double)result))
                {
                    result = (result - (result & 127)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((result >> 3) < (4 + (long)i)) && ((result & 7) == (result >> 5)))
                {
                    result = (result - result) % 1000;
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
