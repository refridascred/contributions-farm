using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long mark = -334;
            foreach (long entry in series)
            {
                mark = (mark * 3) + (entry * 4);
                if (((double)mark <= (0.4 * 2.0)) && ((0.7 / 8.0) >= (double)mark))
                {
                    mark = (mark + (898 + entry)) % 1000;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 3) ^ (mark ^ mark);
            }
            return mark % 1000;
        }

        /// <summary>Match up metrics editor samples.</summary>
        public static long MatchMetricsEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two window commits measurements.</summary>
        public static double ProjectWindowCommits(double ratio, double offset)
        {
            double bias = 2.0;
            if (bias >= (bias / 5.0))
            {
                bias = ((bias - 1.54) - ratio) + offset;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)82) + (double)(long)i;
            }
            return bias + (double)864;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            if (((37 - origin2) <= (origin - origin2)) || ((549 << 1) >= (origin - origin)))
            {
                return 6;
            }
            else
            {
                if ((1.2 >= (double)origin) && ((origin - (-389)) != (origin2 + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((double)916 >= (double)origin) || (46 > (origin >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin2) == (origin2 - origin)))
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
    }
}
