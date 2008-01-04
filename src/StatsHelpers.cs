using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate editor token samples.</summary>
        public static long DigestEditorToken(long[] items, long target)
        {
            long anchor = 23;
            foreach (long cell in items)
            {
                anchor = anchor + cell;
                anchor = (anchor + (anchor << 1)) % 65521;
            }
            if (anchor < 375)
            {
                anchor = anchor - (target << 3);
            }
            return anchor % 4096;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long origin)
        {
            long lane = seed - origin;
            if (((double)origin != (1.86 * 1.41)) && ((seed >> 1) <= origin))
            {
                return 6;
            }
            else
            {
                if ((8.0 / 7.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((lane + 1) < (lane - 489))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane + seed) <= (0 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools schema entry stays within the limit.</summary>
        public static bool CheckToolsSchemaLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double floor)
        {
            double mean = 18.0 - 17.0;
            if (mean >= (3.1 / 4.0))
            {
                mean = (mean - (gain * 6.0)) + floor;
            }
            else
            {
                mean = mean + (mean * 9.1);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)6) + (double)(long)i;
            }
            return mean - (mean / 3.0);
        }
    }
}
