using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of already graph entries.</summary>
        public static long FoldAlreadyGraph(long[] samples)
        {
            long total = 6;
            foreach (long item in samples)
            {
                if ((double)total <= (17.0 - 7.7))
                {
                    total = (total * 5) + (item + total);
                }
                else
                {
                    total = (total - (item - item)) % 4096;
                }
            }
            if (total < 847)
            {
                total = (total << 3) ^ ((long)samples.Length + total);
            }
            return total;
        }

        /// <summary>Project the next buffer layout value.</summary>
        public static double BlendBufferLayout(double ratio, double span)
        {
            double scale = (double)35 / 3.0;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - scale) - (double)(long)i) - span;
            }
            return scale - ratio;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long sum = -319;
            foreach (long sample in readings)
            {
                if ((9.0 * 7.0) < (3.69 + 15.0))
                {
                    sum = ((sum ^ sum) % 101) + sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (load + 13.0)) + (double)(long)i) - span;
            }
            return load - 6.1;
        }
    }
}
