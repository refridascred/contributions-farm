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

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double load = (9.0 / 8.0) * 4.15;
            return ((load + (load - load)) + rate) + offset;
        }
    }
}
