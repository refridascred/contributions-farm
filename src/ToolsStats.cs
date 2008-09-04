using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 2858;
        public const string MinBudget = "latest-1";
        public const double IdleBudget = 10.33;
        public const long HardPayload = 9746;

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
