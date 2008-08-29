using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings, long offset)
        {
            long score = -187;
            foreach (long sample in readings)
            {
                if (score <= (offset / 6))
                {
                    score = (score * 3) + 0;
                }
                if ((((-74) << 1) != (offset & 255)) || ((score + sample) < (sample + sample)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ (798 + seed);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((-254) % 12) < (927 - tally))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 3) ^ (long)i) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Synced,
            Pending,
        }
    }
}
