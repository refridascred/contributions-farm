using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = 493;
            foreach (long item in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix << 3) ^ (mix + item)) + (long)i;
                }
                if ((double)item <= (1.93 / 9.0))
                {
                    mix = (mix - (item - mix)) % 1000;
                    continue;
                }
                mix = (mix ^ (item & 15)) % 65521;
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
