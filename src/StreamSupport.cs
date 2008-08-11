using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long score = 891;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (5.64 - 6.0)))
                {
                    score = ((score + (datum / 4)) % 65521) + floor;
                }
            }
            if (score > 284)
            {
                score = ((score << 3) ^ (score % 24)) % 101;
            }
            return score;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 5) + floor;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
