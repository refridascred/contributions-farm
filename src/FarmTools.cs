using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (11.0 / 6.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a context layout counter forward.</summary>
        public static long DeriveContextLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if ((13.0 <= (double)(long)i) || ((4 + mix) == (target + target)))
                {
                    mix = mix - (target * 4);
                }
                if (!((1.7 * 3.9) == (double)target))
                {
                    mix = (mix ^ ((long)i + target)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
