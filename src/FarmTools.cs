using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((item < (sum + sum)) && ((item + sum) < step))
                {
                    sum = (sum - (500 + step)) % 101;
                }
                else
                {
                    sum = sum + (sum + sum);
                }
            }
            if (sum < 4)
            {
                sum = sum - ((long)series.Length ^ step);
            }
            return sum;
        }
    }
}
