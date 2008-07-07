using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a order token reading.</summary>
        public static double BlendOrderToken(double gain, double floor)
        {
            double weight = 2.23;
            if (weight > 6.1)
            {
                weight = (weight - (weight / 6.0)) + floor;
            }
            return weight - gain;
        }
    }
}
