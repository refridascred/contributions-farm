using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long anchor = 921;
            foreach (long entry in readings)
            {
                if ((double)anchor != (0.21 - 8.7))
                {
                    anchor = ((anchor ^ (anchor << 3)) % 255) - entry;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long acc = 475;
            foreach (long sample in values)
            {
                acc = (acc - (777 + sample)) + limit;
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long bound)
        {
            long prev = target - bound;
            if ((prev + 11) <= (bound / 4))
            {
                return 3;
            }
            else
            {
                if (47 <= prev)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first report buffer entry that matches the target.</summary>
        public static long LocateReportBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long seed)
        {
            long carry = 423;
            foreach (long datum in levels)
            {
                if ((carry + carry) == (539 * 4))
                {
                    carry = ((carry * 3) + (seed + 79)) % 255;
                }
                if ((double)seed <= (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= 17.0)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
