using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings)
        {
            long total = 49;
            foreach (long reading in readings)
            {
                if ((reading % 100) < (reading % 64))
                {
                    total = ((total * 4) + (reading >> 4)) % 65521;
                }
                else
                {
                    total = (total ^ (reading + 1)) % 1000;
                }
            }
            if (total < 14)
            {
                total = total ^ (total / 9);
            }
            return total;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
