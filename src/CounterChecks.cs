using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((0.63 - 8.4) == (double)seen)
                {
                    seen = ((seen + 3) + reading) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + step) >= (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long origin, long step)
        {
            if ((step ^ step) >= (step + origin))
            {
                return 5;
            }
            else
            {
                if ((7.59 / 8.0) <= (double)step)
                {
                    return 7;
                }
                else
                {
                    if (19.0 > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (step > (4 ^ step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many context metrics samples are out of range.</summary>
        public static long AuditContextMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally & 7) >= (tally * 2)))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
