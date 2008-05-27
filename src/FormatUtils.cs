using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of stats report readings.</summary>
        public static long FoldStatsReport(long[] data, long origin)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                if (((5.63 - 15.0) < (double)reading) && (reading >= (mark + 805)))
                {
                    mark = mark + (origin - mark);
                }
                if (0.4 < (double)reading)
                {
                    mark = ((mark << 3) ^ (reading & 15)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long CountFilterGraphMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((0.3 - 6.82) >= (double)reading)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long origin)
        {
            if ((step << 2) >= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (step <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) < 353)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two report queue measurements.</summary>
        public static double ScaleReportQueue(double rate, double floor)
        {
            double ratio = floor + 0.4;
            if (ratio >= (rate + ratio))
            {
                ratio = ratio + (ratio / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (double)2;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
