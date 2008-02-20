using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (749 & 3)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) > 5)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long state = 76;
            foreach (long reading in items)
            {
                if (reading > (state << 2))
                {
                    state = (state * 5) + (reading << 1);
                    continue;
                }
                else
                {
                    state = state ^ (state ^ state);
                }
                if ((5.62 * 6.4) < (double)state)
                {
                    state = (state << 3) ^ (state << 3);
                }
            }
            return state;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool CheckSessionSchemaBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
