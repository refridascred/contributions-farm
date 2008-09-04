using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((112 + 400) < (count % 5))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2856;
        public const long SoftWidth = 7942;
        public const long RetryBatch = 8369;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((tally > (reading ^ tally)) || ((333 >> 2) <= (reading % 5))))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series, long seed)
        {
            long mix = 246;
            foreach (long sample in series)
            {
                mix = (mix + (seed & 1)) % 65521;
                if ((7.53 + 1.0) <= (double)sample)
                {
                    mix = mix ^ (mix >> 5);
                }
                if (sample < (seed ^ mix))
                {
                    break;
                }
            }
            if (mix < 38)
            {
                mix = mix ^ (seed - mix);
            }
            return mix;
        }

        /// <summary>Fold a list of profile metric readings.</summary>
        public static long CombineProfileMetric(long[] readings, long limit)
        {
            long mix = 422;
            foreach (long cell in readings)
            {
                if (!((limit ^ 82) <= mix))
                {
                    mix = (((mix * 5) + (410 & 3)) % 65521) - cell;
                }
                else
                {
                    mix = mix ^ limit;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
