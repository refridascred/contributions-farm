using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count entry session pairs that satisfy a relation.</summary>
        public static long CompareEntrySessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate token metrics readings against a bound.</summary>
        public static bool ValidateTokenMetricsLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
