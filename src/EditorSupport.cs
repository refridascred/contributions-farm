using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Retry,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Roll a batches account counter forward.</summary>
        public static long SeriesBatchesAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((target + (-7)) == (long)i))
                {
                    acc = (acc * 4) + (-7);
                }
                acc = (acc + (acc % 2)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double offset)
        {
            double weight = (ratio - 8.94) + (ratio + ratio);
            if (weight <= weight)
            {
                weight = weight + offset;
            }
            return weight + (offset * 5.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5368;
        public const long StepContext = 1780;
        public const long StepWidth = 5195;

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long offset)
        {
            if ((bound + 170) < offset)
            {
                return 8;
            }
            else
            {
                if (bound <= (offset / 2))
                {
                    return 0;
                }
                else
                {
                    if (((offset % 97) <= 4) || ((double)offset == (7.0 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
