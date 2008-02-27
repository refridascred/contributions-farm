using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2142;
        public const double MaxSupport = 57.36;
        public const double MinSupport = 78.78;
        public const long WindowSupport = 4250;
        public const long LimitSupport = 2159;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)offset >= (double)datum) || (count >= offset)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Flag { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next editor graph value.</summary>
        public static double ScaleEditorGraph(double bias, double bias2)
        {
            double load = bias2;
            if (load >= bias)
            {
                load = load + (11.0 + bias);
            }
            else
            {
                load = load + (bias2 + bias);
            }
            return load - (double)343;
        }

        /// <summary>Derive the next session window value from a seed.</summary>
        public static long StepSessionWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((sum <= (offset >> 4)) && ((sum + sum) != (offset + (long)i)))
                {
                    sum = (sum - ((long)i + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ offset) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum + (sum ^ sum)) % 65521) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
