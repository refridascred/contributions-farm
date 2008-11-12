using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long CountBufferNotesMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((entry + hits) < (entry & 15)) && (entry <= (4 * 3)))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (16 - mix)) % 255;
                if ((1.0 / 9.0) < (double)(long)i)
                {
                    mix = (mix * 5) + (-862);
                    mix = ((mix << 3) ^ (mix << 2)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
