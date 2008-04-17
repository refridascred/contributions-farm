using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long seed)
        {
            long sum = 885;
            foreach (long entry in series)
            {
                if ((seed + sum) > (entry - (long)series.Length))
                {
                    sum = sum ^ sum;
                }
                if (((double)sum > 8.6) && (sum <= entry))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many notes tools samples are out of range.</summary>
        public static long TallyNotesToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches < (cell & 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
