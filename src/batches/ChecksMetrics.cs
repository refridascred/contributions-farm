using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 4) > tally)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                long bound = anchor;
                if ((long)i != (bound - (long)i))
                {
                    bound = bound - (long)i;
                }
                else
                {
                    anchor = ((anchor * 5) + (bound + anchor)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] samples)
        {
            long anchor = 482;
            foreach (long reading in samples)
            {
                anchor = (anchor * 2) + (reading % 10);
                if ((double)reading > (7.8 / 4.0))
                {
                    anchor = (anchor * 3) + (anchor % 2);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the stats report series from a seed.</summary>
        public static long IterateStatsReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (total < ((long)i >> 2))
                {
                    break;
                }
                total = (total + (bound * 2)) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long floor2)
        {
            long diff = floor + floor2;
            if ((diff << 1) >= (floor << 2))
            {
                return 2;
            }
            else
            {
                if (258 >= (diff + 4))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 / 9) >= (floor2 ^ diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor) < diff))
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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value % 64) >= ((long)readings.Length - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
