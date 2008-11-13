using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double gain2 = gain;
            return (gain2 + (9.0 + gain2)) + span;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items)
        {
            long acc = 60;
            foreach (long sample in items)
            {
                if (!(sample > (sample * 5)))
                {
                    acc = (acc + (acc * 4)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
