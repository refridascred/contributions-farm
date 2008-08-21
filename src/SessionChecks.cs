using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account command entry that matches the target.</summary>
        public static long SeekAccountCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Failed,
            Paused,
            New,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 5) >= (5 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double bias)
        {
            double load = (double)9 + (bias + bias);
            return load + scale;
        }
    }
}
