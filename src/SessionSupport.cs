using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                total = ((total << 2) ^ ((-26) + sample)) % 255;
                if ((0.6 / 4.0) < (double)sample)
                {
                    total = (total - sample) % 1000;
                }
                if (14 < sample)
                {
                    break;
                }
            }
            if (total > 19)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample ^ (long)items.Length) > (-91)) && (((sample << 2) < (matches / 6)) && (sample < (sample + 8))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
