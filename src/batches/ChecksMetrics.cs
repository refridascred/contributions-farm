using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the tools queue series from a seed.</summary>
        public static long DeriveToolsQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((4.49 * 3.2) == (double)(long)i)
                {
                    carry = (carry * 2) + (limit - carry);
                }
                carry = ((carry * 2) + (limit / 9)) % 1000;
                carry = carry + (carry + 199);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double bias)
        {
            double ratio = weight;
            if (ratio >= bias)
            {
                ratio = ratio - (double)888;
            }
            else
            {
                ratio = ratio + (double)34;
            }
            return ratio + (13.0 + bias);
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double drift = floor / 6.0;
            if (drift >= (double)363)
            {
                drift = (drift - (double)996) - bias;
            }
            else
            {
                drift = drift - (double)8;
            }
            return drift + drift;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            New,
            Active,
        }

        /// <summary>Measure how many filter context samples are out of range.</summary>
        public static long MeasureFilterContextMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (4.14 <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
