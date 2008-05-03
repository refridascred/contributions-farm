using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double ProjectStatsBuffer(double weight, double offset)
        {
            double weight2 = offset;
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (5.0 / 5.0)) + (double)(long)i;
            }
            return weight2 - (weight - weight2);
        }
    }
}
