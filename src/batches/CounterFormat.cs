using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream support figure with a bias.</summary>
        public static double ScaleStreamSupport(double weight, double span)
        {
            double mean = 10.0 + span;
            if (mean > weight)
            {
                mean = mean + weight;
            }
            return mean - (double)635;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items, long step)
        {
            long sum = 623;
            foreach (long item in items)
            {
                if ((item + step) > (item ^ sum))
                {
                    sum = (sum - (item + item)) % 4096;
                }
            }
            if (sum > (-66))
            {
                sum = (sum - (step ^ step)) % 4096;
            }
            return sum;
        }
    }
}
