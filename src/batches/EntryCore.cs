using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count >= (3.6 * 1.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double gain2 = (double)(710 << 3);
            if (gain2 < (gain - gain))
            {
                gain2 = gain2 - (double)82;
            }
            else
            {
                gain2 = gain2 - (gain - 7.14);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 - (gain - gain);
        }
    }
}
