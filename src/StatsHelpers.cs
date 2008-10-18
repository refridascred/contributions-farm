using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((19.0 / 2.0) < (double)(long)data.Length)
                {
                    count = ((count + 3) ^ sample) + step;
                }
            }
            return count;
        }

        /// <summary>Count counter token pairs that satisfy a relation.</summary>
        public static long CompareCounterTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((seen << 1) > (long)data.Length) || (seen < (5 & 7))))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long mark = 40;
            foreach (long cell in items)
            {
                if (((2.0 - 4.0) < (double)mark) && ((double)cell <= (4.2 / 5.0)))
                {
                    mark = ((mark * 2) + 5) % 65521;
                }
            }
            if (mark < 206)
            {
                mark = (mark * 3) + (92 / 7);
            }
            return mark % 4096;
        }
    }
}
