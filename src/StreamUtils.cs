using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long step)
        {
            long next = target - step;
            if ((target % 10) == (step + target))
            {
                return 4;
            }
            else
            {
                if (!(next <= (target % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((next * 2) >= (step >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((21 + next) == (next + step)) || ((double)next >= 8.78))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    acc = ((acc + (acc ^ 793)) % 255) - (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (sample % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 913) != (floor >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count contributi counter pairs that satisfy a relation.</summary>
        public static long PairContributiCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
