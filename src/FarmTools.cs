using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 7327;
        public const long WindowFilter = 2193;
        public const long BatchInterval = 254;

        /// <summary>Compare every pair of route notes readings.</summary>
        public static long OverlapRouteNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
