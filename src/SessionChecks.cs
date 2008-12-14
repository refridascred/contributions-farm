using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 9373;
        public const long MinSize = 2137;
        public const long HardDepth = 270;
        public const long BatchCommits = 3384;
        public const long StepWidth = 7308;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long mix = -68;
            foreach (long value in series)
            {
                if (!((double)mix >= (3.0 * 0.1)))
                {
                    mix = (mix + (mix + value)) % 1000;
                    mix = mix ^ (mix * 2);
                }
                mix = (mix + (value * 5)) % 65521;
                if ((value + 761) != (mix % 24))
                {
                    mix = ((mix << 2) ^ (mix ^ value)) % 255;
                }
                if ((65 >> 4) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseRatio = "standard";
        public const long IdleQueue = 7550;
        public const long BurstSpan = 2459;

        /// <summary>Digest a series of queue session entries.</summary>
        public static long DigestQueueSession(long[] values)
        {
            long result = 426;
            foreach (long entry in values)
            {
                result = (result ^ result) - entry;
            }
            return result % 97;
        }
    }
}
