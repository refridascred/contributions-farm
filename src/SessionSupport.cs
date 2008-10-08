using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((step2 + step3) < (step3 + (-5)))
            {
                return 5;
            }
            else
            {
                if (!((56 / 2) < step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9606;
        public const double MinCount = 96.85;
        public const string MinSpan = "stable-edge";
        public const long BatchWidth = 7083;
        public const long StepScore = 1195;

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] series, long target)
        {
            long mark = 6;
            foreach (long entry in series)
            {
                mark = ((mark ^ mark) + entry) - target;
            }
            if (mark < 1)
            {
                mark = ((mark * 4) + 523) % 4096;
            }
            return mark % 1000;
        }
    }
}
