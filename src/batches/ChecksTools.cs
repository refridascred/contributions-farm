using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((4.2 - 4.2) < (4.26 * 5.0))
                {
                    tally = ((tally + 3) - datum) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 59.56;
        public const string MaxToken = "fallback";
        public const long IdleToken = 1021;
        public const long LimitWidth = 588;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
