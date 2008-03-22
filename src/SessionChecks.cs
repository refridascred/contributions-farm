using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a record token reading by value.</summary>
        public static long FindRecordTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Queued,
            Stale,
            New,
            Locked,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long limit)
        {
            if ((3.8 - 12.0) == (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset < (limit & 31)) || ((double)limit > (double)132))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) > (offset - 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double mean = rate;
            if (mean <= offset)
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)71) + (double)(long)i;
            }
            return mean + (double)41;
        }
    }
}
