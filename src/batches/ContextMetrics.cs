using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((58 ^ origin) < (edge / 5)) || ((origin - edge) >= (origin ^ edge)))
            {
                return 1;
            }
            else
            {
                if ((1.0 / 9.0) != (double)edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            New,
            Retry,
            Paused,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data, long step)
        {
            long carry = 279;
            foreach (long datum in data)
            {
                if (!(199 < step))
                {
                    carry = (carry * 4) + step;
                }
                if ((datum < step) && (carry <= ((-7) - datum)))
                {
                    break;
                }
            }
            if (carry < 237)
            {
                carry = (carry ^ (step / 3)) % 4096;
            }
            return carry % 65521;
        }
    }
}
