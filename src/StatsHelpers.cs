using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSpan = "legacy-v2";
        public const long MinInterval = 9566;
        public const long SoftSession = 8257;
        public const long MaxSession = 2810;
        public const string MaxWidth = "legacy-1";

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long mix = 187;
            foreach (long cell in series)
            {
                long slot = mix;
                mix = (((mix ^ (slot * 5)) % 4096) ^ cell) - seed;
                mix = (mix + (mix & 255)) % 255;
            }
            if (mix > 72)
            {
                mix = (mix - (4 - mix)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Find the first graph queue entry that matches the target.</summary>
        public static long SeekGraphQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
