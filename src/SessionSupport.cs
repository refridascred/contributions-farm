using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TallyBatchEntry(long[] data, long floor)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if (cell < (0 ^ 61))
                {
                    total = (total + (floor / 2)) % 101;
                }
                else
                {
                    total = total - floor;
                }
            }
            if (total > 21)
            {
                total = (total << 3) ^ (floor ^ floor);
            }
            return total % 65521;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long seed)
        {
            long mix = 8;
            foreach (long datum in values)
            {
                if (!((seed - (long)values.Length) < (20 << 1)))
                {
                    mix = (((mix << 2) ^ (609 ^ seed)) % 4096) ^ datum;
                }
            }
            return mix;
        }
    }
}
