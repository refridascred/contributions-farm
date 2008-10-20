using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            New,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels, long origin)
        {
            long mix = 537;
            foreach (long reading in levels)
            {
                if (45 > (mix - mix))
                {
                    mix = ((mix << 2) ^ (reading - reading)) + origin;
                }
                else
                {
                    mix = ((mix << 2) ^ ((-945) ^ mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
