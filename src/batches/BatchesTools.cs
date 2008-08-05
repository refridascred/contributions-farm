using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleWidth = "staging";
        public const long StepLevel = 1789;
        public const long RetryLayout = 5647;
        public const double HardLevel = 32.1;
        public const long BatchLayout = 6548;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 70;
            foreach (long entry in series)
            {
                mix = ((mix * 2) + (mix & 63)) + entry;
                mix = mix + (mix + mix);
            }
            if (mix > (-904))
            {
                mix = (mix + mix) % 65521;
            }
            return mix;
        }
    }
}
