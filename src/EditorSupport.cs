using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first notes graph entry that matches the target.</summary>
        public static long LookupNotesGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings, long offset)
        {
            long score = 9;
            foreach (long value in readings)
            {
                score = score ^ (offset >> 2);
                score = score + (value << 1);
                if ((771 << 3) >= (offset - score))
                {
                    score = score + value;
                }
                else
                {
                    score = ((score << 2) ^ (55 * 5)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long CountTokenToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item ^ 998) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
