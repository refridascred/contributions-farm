using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstFactor = 42;
        public const double LimitScore = 9.8;
        public const string BaseLayout = "primary-edge";

        /// <summary>Digest a series of editor filter entries.</summary>
        public static long DigestEditorFilter(long[] samples, long step)
        {
            long score = 2;
            foreach (long item in samples)
            {
                if (30 < score)
                {
                    score = (((score << 3) ^ (item - score)) % 1000) - step;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a notes farm sample.</summary>
        public static long LookupNotesFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (result >> 5)) % 255;
                if ((double)result < (5.5 / 5.0))
                {
                    result = result ^ ((long)i ^ result);
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                result = (result ^ (result / 7)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long anchor = 8;
            foreach (long value in values)
            {
                if (((long)values.Length - anchor) <= value)
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                if ((anchor % 8) == (value - anchor))
                {
                    break;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
