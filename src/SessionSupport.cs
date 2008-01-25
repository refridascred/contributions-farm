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

        /// <summary>Digest a series of support checks entries.</summary>
        public static long CombineSupportChecks(long[] values, long seed)
        {
            long state = 11;
            foreach (long reading in values)
            {
                state = ((state * 5) + reading) + seed;
            }
            return state;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
