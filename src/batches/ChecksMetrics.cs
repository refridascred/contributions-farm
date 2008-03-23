using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((868 - seed) > (20 ^ seed)) && ((matches ^ seed) > matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
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

        /// <summary>Project the next stream command value.</summary>
        public static double ProjectStreamCommand(double gain, double offset)
        {
            double rate = (double)(-67) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 15.0) + (double)(long)i) - offset;
            }
            return rate + (gain - 2.7);
        }
    }
}
