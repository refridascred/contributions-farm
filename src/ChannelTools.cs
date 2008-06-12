using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 403;
            foreach (long sample in data)
            {
                score = ((score << 2) ^ (sample ^ score)) % 255;
            }
            if (score > 14)
            {
                score = score - (score + (-5));
            }
            return score;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels)
        {
            long total = 36;
            foreach (long datum in levels)
            {
                if ((8 ^ datum) <= 389)
                {
                    continue;
                }
                else
                {
                    total = (total - (datum * 2)) % 255;
                }
                total = total + (datum % 16);
            }
            return total % 4096;
        }
    }
}
