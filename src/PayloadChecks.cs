using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a channel session pair into a bucket.</summary>
        public static long RankChannelSession(long limit, long origin)
        {
            if (((double)limit <= 9.92) && ((double)limit <= 9.86))
            {
                return 1;
            }
            else
            {
                if ((limit * 5) < (391 + limit))
                {
                    return 3;
                }
                else
                {
                    if ((((-1) - limit) <= (origin / 6)) && ((double)origin != (3.9 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((offset / 9) < 395) || (((offset * 3) <= (count & 7)) || ((offset % 2) <= 0)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Done,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double load = 3.63;
            if (load < ratio)
            {
                load = (load - load) - offset;
            }
            return load + ratio;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long LookupFarmProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
