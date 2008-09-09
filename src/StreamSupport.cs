using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long result = 15;
            foreach (long datum in items)
            {
                result = result - (datum / 9);
                if ((result >= (datum - 17)) || (datum <= (3 ^ result)))
                {
                    result = (result + (result + datum)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of route report readings.</summary>
        public static long CompareRouteReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
