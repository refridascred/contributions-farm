using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (count + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a commits batches counter forward.</summary>
        public static long RollCommitsBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > (double)35)
            {
                bias = bias + (floor * 5.9);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (bias / 5.0)) - (double)(long)i;
            }
            return bias - (double)(-343);
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 + (double)34) + ratio;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - 0.1) + (double)(long)i;
            }
            return ratio2 + (double)685;
        }
    }
}
