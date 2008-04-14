using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double weight = 3.0 * 14.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] items)
        {
            long sum = 219;
            foreach (long datum in items)
            {
                if (652 <= (datum - datum))
                {
                    sum = (sum ^ (sum << 3)) % 101;
                }
                if ((sum <= (sum / 8)) && ((51 >> 5) >= (datum + sum)))
                {
                    sum = ((sum << 2) ^ (datum % 24)) % 255;
                }
            }
            if (sum > 811)
            {
                sum = (sum * 3) + (sum % 7);
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 2670;
        public const long DefaultRoute = 4276;
        public const long WindowCount = 4709;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
