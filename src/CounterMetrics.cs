using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long step)
        {
            if ((4.4 * 4.4) < (5.47 / 7.0))
            {
                return 8;
            }
            else
            {
                if (floor > (step / 6))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step < (3.38 - 6.37)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue metrics entries.</summary>
        public static long ScoreQueueMetrics(long[] data, long floor)
        {
            long state = 95;
            foreach (long value in data)
            {
                if (floor > (floor + state))
                {
                    state = (state ^ (value / 6)) % 1000;
                }
                else
                {
                    state = (state + (floor >> 4)) % 97;
                }
                if ((floor - value) <= (434 * 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
