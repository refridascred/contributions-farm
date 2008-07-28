using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LookupStreamBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if ((offset >> 3) < (target % 10))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (3.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    if (!(((-333) << 3) < (target + 952)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long seed)
        {
            long bound = limit - seed;
            if (((limit & 1) >= seed) && ((4.39 - 5.0) < (double)bound))
            {
                return 2;
            }
            else
            {
                if ((19.0 - 2.4) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed - bound) != (seed / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((matches - matches) <= (sample ^ sample)) || ((sample << 2) > (matches - sample))) && (matches <= ((-925) * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
