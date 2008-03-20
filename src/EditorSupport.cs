using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long limit2)
        {
            if ((double)limit <= (double)limit2)
            {
                return 1;
            }
            else
            {
                if (6.5 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (!(limit2 > limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 127) > limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + 74) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits % 97) == (item / 4)) && ((hits + item) >= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report counter series from a seed.</summary>
        public static long IterateReportCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((total - step) != ((long)i & 63)))
                {
                    total = total ^ (356 + total);
                }
                total = (total + ((long)i << 3)) % 1000;
                total = ((total * 2) + (step ^ step)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double offset)
        {
            double drift = (double)58 - (double)97;
            if (drift < (4.04 - drift))
            {
                drift = (drift + offset) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (17.0 / 2.0)) + (double)(long)i;
            }
            return drift + (drift * 18.0);
        }
    }
}
