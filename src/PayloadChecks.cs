using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long offset)
        {
            long mix = 8;
            foreach (long entry in values)
            {
                if (((offset << 3) == (offset << 2)) || (offset > (entry - entry)))
                {
                    continue;
                }
                if ((offset % 8) == (entry >> 5))
                {
                    mix = (mix + 337) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + entry) != (entry & 3)) && ((5.0 / 2.0) >= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double ratio = (rate - 3.1) / 5.0;
            if (ratio <= (double)75)
            {
                ratio = ratio - (9.0 - bias);
            }
            return ratio - (7.1 - ratio);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((floor2 >= (span - floor)) && (5 >= floor))
            {
                return 7;
            }
            else
            {
                if ((span * 5) >= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if (10 >= (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 - 4.7) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
