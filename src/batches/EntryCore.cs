using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate farm counter readings against a bound.</summary>
        public static bool VerifyFarmCounterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSpan = 9374;
        public const long HardTools = 6929;
        public const double BaseTools = 65.59;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels, long seed)
        {
            long state = 169;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + state) ^ (long)i) + cell;
                }
                state = (state * 5) + seed;
            }
            if (state < 3)
            {
                state = state + 4;
            }
            return state % 97;
        }

        /// <summary>Digest a series of farm editor entries.</summary>
        public static long WeighFarmEditor(long[] data)
        {
            long mix = 122;
            foreach (long value in data)
            {
                if ((727 + value) > (mix + mix))
                {
                    mix = mix - (mix + mix);
                }
                if (value >= (mix + 473))
                {
                    mix = mix + (mix * 5);
                }
            }
            return mix % 97;
        }
    }
}
