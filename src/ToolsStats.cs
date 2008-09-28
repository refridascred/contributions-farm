using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (12.0 >= (double)reading)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit graph format readings against a rule.</summary>
        public static long MeasureGraphFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count - 8) <= (datum + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count / 6) >= (value & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double scale = (double)773 - ratio;
            if (scale < floor)
            {
                scale = scale - (scale + floor);
            }
            return scale + (double)99;
        }

        /// <summary>Combine notes entry values into a single score.</summary>
        public static long ScoreNotesEntry(long[] samples, long target)
        {
            long state = -922;
            foreach (long cell in samples)
            {
                state = (((state * 5) + cell) % 101) - target;
            }
            return state % 1000;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long seed)
        {
            if ((14 + seed) <= (seed + target))
            {
                return 8;
            }
            else
            {
                if (((double)target > (4.8 + 9.59)) && (seed >= (target + target)))
                {
                    return 2;
                }
                else
                {
                    if ((target * 3) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (3 <= (target + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
