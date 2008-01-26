using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 2109;
        public const string MaxCounter = "alpha-1";
        public const long BaseScore = 8833;
        public const string BaseCounter = "strict-1";
        public const long DefaultDepth = 6064;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long carry = 604;
            foreach (long sample in values)
            {
                if ((9.2 * 1.0) != (double)sample)
                {
                    carry = ((carry << 3) ^ sample) % 1000;
                }
                else
                {
                    carry = carry ^ (sample - carry);
                }
            }
            if (carry < 615)
            {
                carry = (carry ^ (60 - carry)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
