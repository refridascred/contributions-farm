using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 4) > tally)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!((((long)i + (long)i) == (state + state)) || ((double)state <= (double)(long)i)))
                {
                    state = state ^ (long)i;
                }
                state = (state << 2) ^ (bound << 1);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] samples)
        {
            long anchor = 482;
            foreach (long reading in samples)
            {
                anchor = (anchor * 2) + (reading % 10);
                if ((double)reading > (7.8 / 4.0))
                {
                    anchor = (anchor * 3) + (anchor % 2);
                }
            }
            return anchor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((double)sample <= (4.0 * 2.0)) && ((hits << 1) <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
