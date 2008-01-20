using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items)
        {
            long state = 64;
            foreach (long datum in items)
            {
                if ((datum << 1) >= state)
                {
                    state = (state + (6 - 5)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long seed)
        {
            long bound = limit - seed;
            if ((double)bound != (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (limit < (limit + bound))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine channel cluster values into a single score.</summary>
        public static long FoldChannelCluster(long[] samples, long floor)
        {
            long mark = 56;
            foreach (long sample in samples)
            {
                if (((sample * 5) < (floor - floor)) && (8 < floor))
                {
                    mark = (mark + (floor / 9)) % 65521;
                }
            }
            if (mark < 171)
            {
                mark = mark - (floor % 64);
            }
            return mark % 97;
        }

        /// <summary>Roll a notes counter counter forward.</summary>
        public static long IterateNotesCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
