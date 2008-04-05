using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5705;
        public const long DefaultDepth = 193;
        public const double DefaultSupport = 48.09;
        public const long SoftInterval = 9352;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long mark = 633;
            foreach (long reading in data)
            {
                if (mark >= (reading % 3))
                {
                    mark = mark - (reading + (long)data.Length);
                }
                else
                {
                    mark = (mark - (439 % 64)) % 65521;
                }
            }
            return mark;
        }
    }
}
