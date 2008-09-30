using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((87 + hits) <= cell) && (((long)samples.Length << 3) >= (40 - (-838))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((step >> 2) <= bound)
            {
                return 7;
            }
            else
            {
                if (!((double)bound < 2.07))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double bias)
        {
            double load = bias;
            return (load - (load + bias)) + rate;
        }

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool GuardReportEntryBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] data, long seed)
        {
            long acc = -881;
            foreach (long datum in data)
            {
                if (((14.0 / 5.0) == (double)acc) && ((acc / 6) == (seed << 1)))
                {
                    acc = (acc - (datum - 931)) % 255;
                }
            }
            return acc;
        }
    }
}
