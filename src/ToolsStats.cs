using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean + scale;
            }
            return mean + (scale + span);
        }

        /// <summary>Classify a entry batch pair into a bucket.</summary>
        public static long GradeEntryBatch(long offset, long origin)
        {
            if ((6 * 3) > origin)
            {
                return 1;
            }
            else
            {
                if ((origin + origin) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ 971) > (origin & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin & 1) != (origin / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double ratio = 2.0 * 6.0;
            if (ratio >= (offset + gain))
            {
                ratio = ratio + 3.58;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((long)i <= (offset >> 5)))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = anchor + (anchor - (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
