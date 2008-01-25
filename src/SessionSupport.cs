using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] samples)
        {
            long sum = 2;
            foreach (long reading in samples)
            {
                sum = (sum ^ (reading + 723)) % 97;
                sum = (sum * 4) + 52;
                if (((double)reading < (5.9 / 2.0)) || ((5.4 * 20.0) >= (double)reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long mix = 69;
            foreach (long datum in series)
            {
                mix = (mix + seed) % 101;
                mix = (mix - (datum >> 1)) % 1000;
                mix = (mix * 2) + (7 / 3);
            }
            return mix;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
