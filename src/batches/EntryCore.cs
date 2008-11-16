using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long sum = -2;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum * 2) + (sum + (long)i);
                }
                if (((sum ^ datum) == (datum * 5)) && (sum <= (sum % 10)))
                {
                    continue;
                }
                sum = (sum * 5) + (long)levels.Length;
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items, long origin)
        {
            long carry = 51;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ (entry + origin)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double floor)
        {
            double gain = (floor - scale) * 20.0;
            if (gain >= (double)876)
            {
                gain = gain + (5.3 - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (scale * 4.0);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
