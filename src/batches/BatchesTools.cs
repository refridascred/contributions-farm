using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches > 19.0)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long bound)
        {
            long carry = 563;
            foreach (long reading in series)
            {
                carry = carry - (carry / 5);
                if ((2.8 - 8.5) == (double)carry)
                {
                    carry = (carry - bound) % 1000;
                }
                carry = (carry + reading) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
