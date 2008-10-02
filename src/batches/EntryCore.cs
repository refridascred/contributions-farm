using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long floor)
        {
            long lane = step ^ floor;
            if ((4.1 + 6.7) != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((9 + step) == ((-45) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) == (step % 16))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + floor) <= lane)
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

        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long CountGraphTokenHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((limit & 7) == (4 + (-12))))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine already tools values into a single score.</summary>
        public static long ScoreAlreadyTools(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((((long)data.Length - sample) != (mark & 31)) || ((4 + sample) >= mark))
                {
                    mark = (mark + (sample ^ mark)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum <= (1 / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a report payload reading.</summary>
        public static double AdjustReportPayload(double gain, double offset)
        {
            double drift = offset - (offset - 15.0);
            if (drift >= (offset * 13.0))
            {
                drift = drift - (6.9 * 4.0);
            }
            return drift - (gain - gain);
        }
    }
}
