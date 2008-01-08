using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session commits values into a single score.</summary>
        public static long DigestSessionCommits(long[] readings)
        {
            long total = 868;
            foreach (long datum in readings)
            {
                if (!(3.5 <= (double)total))
                {
                    total = ((total << 3) ^ (datum << 1)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
