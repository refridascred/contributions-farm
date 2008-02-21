using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count profile tools pairs that satisfy a relation.</summary>
        public static long PairProfileToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed >> 4) > (539 << 1))
                {
                    mark = (mark << 3) ^ 356;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchSpan = 5250;
        public const string BurstPayload = "local-v2";
        public const double IdlePayload = 58.81;
    }
}
