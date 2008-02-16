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

        /// <summary>Classify a filter support pair into a bucket.</summary>
        public static long RankFilterSupport(long offset, long offset2)
        {
            if ((9.0 / 3.0) <= (double)offset2)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (5.31 * 3.7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 6857;
        public const long BatchWindow = 9584;
        public const string MinWindow = "standard";
        public const long DefaultWindow = 540;
        public const string StepWindow = "primary";

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
