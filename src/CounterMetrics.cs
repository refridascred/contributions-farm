using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double weight = 11.0;
            if (weight < (12.0 / 7.0))
            {
                weight = (weight - (weight / 2.0)) + span;
            }
            else
            {
                weight = weight + scale;
            }
            return weight - (scale + 3.69);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double offset)
        {
            double weight = ratio;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)(long)i) - offset;
            }
            return weight + (double)5;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series, long seed)
        {
            long state = 23;
            foreach (long cell in series)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state << 2) ^ ((long)i2 + seed);
                }
                state = ((state << 3) ^ (cell & 1)) % 65521;
                if ((cell / 6) < (cell >> 3))
                {
                    break;
                }
            }
            return state;
        }
    }
}
