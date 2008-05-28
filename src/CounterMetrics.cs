using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (mix - 2)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long MeasureCommitsFarmOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen * 2) >= 586)
                {
                    seen = ((seen + 3) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix ^ (seed / 6)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
