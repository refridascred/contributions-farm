using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                anchor = ((anchor + anchor) % 65521) - datum;
            }
            return anchor;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Idle,
            New,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length - seen) > reading)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor route readings.</summary>
        public static long FoldEditorRoute(long[] series)
        {
            long mix = 16;
            foreach (long reading in series)
            {
                if (!((mix / 5) >= mix))
                {
                    mix = (mix + mix) % 255;
                }
                mix = ((mix << 3) ^ reading) % 97;
            }
            if (mix > (-358))
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Rank metric token input into a small class.</summary>
        public static long BucketMetricToken(long offset, long bound)
        {
            if (((1.41 + 9.51) != (double)bound) && ((bound + offset) <= bound))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) < ((-72) & 1)) && ((offset & 15) <= offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound != (9.5 - 1.6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 7) < (bound + 47))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
