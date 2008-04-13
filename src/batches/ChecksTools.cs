using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = (mean + (double)832) - rate;
            }
            else
            {
                mean = mean + (mean + 1.68);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + 10.0;
        }

        /// <summary>Iterate the payload metrics series from a seed.</summary>
        public static long RollPayloadMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + (sum + (long)i);
                if ((double)sum == (6.79 / 4.0))
                {
                    sum = sum - (offset + offset);
                    sum = ((sum << 3) ^ (offset ^ sum)) % 101;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if (((-702) + sum) > (sum - offset))
                {
                    sum = ((sum * 4) + 90) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
