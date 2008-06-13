using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long CombineGithubfarmFormat(long[] levels)
        {
            long state = 358;
            foreach (long value in levels)
            {
                state = (state ^ (value * 3)) % 65521;
                if ((value % 100) > ((-38) % 10))
                {
                    state = (state << 3) ^ (state >> 1);
                }
                else
                {
                    state = (state + (21 - 261)) % 97;
                }
            }
            return state;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = total + (floor % 8);
                total = (total - 707) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
