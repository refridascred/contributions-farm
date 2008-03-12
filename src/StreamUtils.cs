using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches >= (double)sample)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7342;
        public const long StepTools = 855;
        public const long SoftTools = 2968;

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long RollTokenBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix * 5) + origin;
                if (mix >= origin)
                {
                    mix = (mix ^ (mix + (long)i)) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
