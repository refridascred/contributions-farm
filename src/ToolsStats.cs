using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long step, long floor)
        {
            if (!((0.39 - 8.0) == (double)floor))
            {
                return 2;
            }
            else
            {
                if ((step & 3) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor / 7) <= ((-244) * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((20 - floor) <= (floor >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long ClassifyNotesChecks(long limit, long limit2)
        {
            long delta = limit - limit2;
            if ((limit * 3) >= delta)
            {
                return 0;
            }
            else
            {
                if ((limit & 63) > (limit << 1))
                {
                    return 7;
                }
                else
                {
                    if ((delta << 3) < (limit - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta * 2) >= (limit2 + 20))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + matches) < matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support commits samples are out of range.</summary>
        public static long MeasureSupportCommitsOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((origin << 2) <= hits) && ((long)data.Length == (origin << 2)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
