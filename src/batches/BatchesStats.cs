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

        /// <summary>Count session queue pairs that satisfy a relation.</summary>
        public static long CompareSessionQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
