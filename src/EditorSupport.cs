using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading == (7.04 + 6.69))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)(-236) <= (double)hits)
                {
                    hits = ((hits + 3) + reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Scale a stats already figure with a bias.</summary>
        public static double ScaleStatsAlready(double weight, double floor)
        {
            double rate = weight - 18.0;
            if (rate <= floor)
            {
                rate = rate - (floor + weight);
            }
            else
            {
                rate = rate - (double)82;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (0.3 / 8.0);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Active,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (long)i) % 255;
                if (!((step << 2) <= (step % 7)))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + step)) % 4096;
                }
                state = (state ^ (step - state)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two token layout measurements.</summary>
        public static double ProjectTokenLayout(double scale, double span)
        {
            double bias = (double)(53 + 34);
            return (bias + scale) + span;
        }
    }
}
