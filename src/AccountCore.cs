using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 9;
            foreach (long reading in levels)
            {
                mix = (mix + reading) % 97;
            }
            return mix;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Queued,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Find the first contributi editor entry that matches the target.</summary>
        public static long SeekContributiEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double ratio, double span)
        {
            double gain = span;
            if (gain <= span)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + 5.89;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (3.2 - 2.6)) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "staging-1";
        public const double StepTimeout = 81.86;
        public const long SoftContributi = 8780;
    }
}
