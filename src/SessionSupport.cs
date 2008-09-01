using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 450;
            foreach (long datum in items)
            {
                if (!((datum / 3) > 28))
                {
                    state = ((state << 3) ^ (datum << 2)) % 97;
                }
                if (!((state - 6) <= (state + (long)items.Length)))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
