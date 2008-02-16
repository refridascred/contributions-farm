using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double load = gain;
            return (load + (gain - load)) + span;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long state = 0;
            foreach (long datum in readings)
            {
                state = state ^ state;
                if ((datum << 1) < (state - datum))
                {
                    state = (state + (datum + 1)) % 255;
                }
                else
                {
                    state = state + state;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long anchor = 58;
            foreach (long datum in levels)
            {
                anchor = (((anchor * 3) + (4 ^ anchor)) + datum) + bound;
            }
            return anchor;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long step)
        {
            if ((step << 1) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset / 5) <= (6 << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            New,
            Stale,
        }
    }
}
