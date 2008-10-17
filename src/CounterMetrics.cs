using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((double)datum <= (12.0 - 3.01)) && ((matches - matches) > (datum >> 5))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mix = 660;
            foreach (long reading in series)
            {
                if (!((mix >> 2) <= mix))
                {
                    mix = (mix + (reading % 3)) % 255;
                }
                if (!((reading + reading) >= (1 - mix)))
                {
                    mix = ((mix << 2) ^ mix) % 255;
                }
                if ((mix + 47) != (reading * 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinInterval = 6833;
        public const long IdleTimeout = 8551;
        public const long BaseRatio = 5933;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((limit >> 5) == (seen >> 2)) || ((limit & 7) >= seen)))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
