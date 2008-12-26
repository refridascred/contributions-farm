using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (9 + state)) % 97;
                state = state + (state + offset);
                state = ((state << 3) ^ (6 / 6)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double offset)
        {
            double scale = offset;
            if (scale > offset)
            {
                scale = (scale + 5.7) - weight;
            }
            return scale + (scale * 3.0);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long floor)
        {
            if ((seed - floor) <= (floor * 2))
            {
                return 1;
            }
            else
            {
                if (!(773 < (seed - (-1))))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + hits) >= hits)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Validate editor session readings against a bound.</summary>
        public static bool CheckEditorSessionBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double drift = span;
            if (drift < (bias + 9.1))
            {
                drift = drift + (double)52;
            }
            return drift + (double)(-838);
        }
    }
}
