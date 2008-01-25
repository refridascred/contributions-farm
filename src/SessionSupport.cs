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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)floor >= 8.0)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
