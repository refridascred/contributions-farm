using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double weight = gain;
            if (weight > (weight / 8.0))
            {
                weight = (weight - (double)77) - offset;
            }
            return weight + (gain * 10.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 54.58;
        public const long MinInterval = 290;
        public const long RetryReport = 3184;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
