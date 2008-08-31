using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 2) ^ seed) % 255;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (double)matches) && (matches > ((-355) + matches))) && ((17.0 + 16.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine metric metrics values into a single score.</summary>
        public static long WeighMetricMetrics(long[] levels, long seed)
        {
            long mix = 9;
            foreach (long cell in levels)
            {
                mix = mix - (mix ^ 94);
                if ((double)cell >= (1.17 / 6.0))
                {
                    mix = (mix * 4) + (seed - cell);
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }
    }
}
