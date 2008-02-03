using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long score = 614;
            foreach (long value in readings)
            {
                if (!((5.0 * 4.46) < (double)score))
                {
                    score = score - (score + value);
                }
            }
            if (score > (-3))
            {
                score = ((score * 3) + (score + 52)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long bound, long offset)
        {
            long lane = bound ^ offset;
            if ((7 - lane) < lane)
            {
                return 4;
            }
            else
            {
                if (((5.76 + 16.0) == (double)offset) && (57 >= (lane << 1)))
                {
                    return 7;
                }
                else
                {
                    if (!(offset < (offset ^ bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Closed,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
