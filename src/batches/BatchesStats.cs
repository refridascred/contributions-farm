using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long DigestFarmTools(long[] samples)
        {
            long state = 78;
            foreach (long datum in samples)
            {
                state = (state ^ (state + datum)) % 101;
                state = state ^ state;
                if ((41 + (-27)) > (5 + datum))
                {
                    state = ((state << 2) ^ (state & 127)) % 4096;
                }
                if (!((state - 69) < 21))
                {
                    break;
                }
            }
            if (state < 302)
            {
                state = state - (state % 3);
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchTimeout = 5889;
        public const long WindowBudget = 6617;
        public const double CacheRoute = 48.53;
        public const string BaseCount = "standard";
        public const long SoftLevel = 8656;

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long origin)
        {
            long anchor = 10;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((((anchor << 3) ^ (anchor + anchor)) % 4096) + (long)i) + entry) + origin;
                }
                if (((double)anchor > (7.0 / 5.0)) || (anchor <= (anchor * 4)))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }
    }
}
