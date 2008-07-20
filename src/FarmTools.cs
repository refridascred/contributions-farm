using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Project the next format stats value.</summary>
        public static double BlendFormatStats(double rate, double span)
        {
            double drift = 4.0;
            return (drift - span) + rate;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
