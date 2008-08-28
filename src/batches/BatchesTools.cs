using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 11.74;
        public const double RetryFormat = 68.75;
        public const double MaxInterval = 4.79;
        public const long DefaultInterval = 6318;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long bound)
        {
            long state = 56;
            foreach (long datum in samples)
            {
                if (((bound % 60) < (datum >> 1)) && ((state + datum) <= ((long)samples.Length & 63)))
                {
                    state = ((state * 5) + (state & 127)) % 255;
                }
                else
                {
                    state = state - (bound % 97);
                }
            }
            if (state > 8)
            {
                state = (state + ((-427) + bound)) % 97;
            }
            return state;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
