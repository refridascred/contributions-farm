using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)step > (double)1))
                {
                    mix = (mix ^ (564 + mix)) % 255;
                }
                else
                {
                    mix = mix ^ step;
                }
                mix = mix + (step ^ mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Failed,
            Paused,
        }
    }
}
