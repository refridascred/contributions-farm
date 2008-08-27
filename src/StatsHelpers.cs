using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics queue readings against a rule.</summary>
        public static long CountMetricsQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 1) <= (matches + matches))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] levels, long origin)
        {
            long mix = 898;
            foreach (long cell in levels)
            {
                if ((double)origin < (2.0 - 4.0))
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = (mix ^ (494 & 1)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally ^ tally) <= item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
