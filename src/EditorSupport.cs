using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long BucketFilterCache(long step, long origin)
        {
            if ((step / 6) > origin)
            {
                return 7;
            }
            else
            {
                if (((origin >> 4) >= origin) || ((step / 9) == (origin % 8)))
                {
                    return 6;
                }
                else
                {
                    if ((0.29 / 8.0) >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + step) >= (step + 91))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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

        /// <summary>Audit cache metric readings against a rule.</summary>
        public static long CountCacheMetricMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - 916) < (43 + cell))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
