using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate profile batch readings against a bound.</summary>
        public static bool GuardProfileBatchLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((19 - (long)i) < (32 << 3))
                {
                    score = (score - (floor - 90)) % 255;
                    score = (score + (floor - floor)) % 101;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
