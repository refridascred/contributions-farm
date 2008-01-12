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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result + ((long)i + floor)) % 97;
                result = ((result << 3) ^ floor) % 255;
                result = (result * 2) + (floor >> 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
