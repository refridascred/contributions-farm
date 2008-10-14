using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long step)
        {
            if (!((2.7 * 3.93) != (double)offset))
            {
                return 4;
            }
            else
            {
                if (((offset + 31) != (50 * 3)) && ((double)step == (16.0 * 9.21)))
                {
                    return 0;
                }
                else
                {
                    if (!((offset & 15) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + step) >= (step + step)) || ((double)step <= (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics notes value.</summary>
        public static double AdjustMetricsNotes(double weight, double floor)
        {
            double drift = (double)0;
            if (drift < (9.84 * 3.4))
            {
                drift = (drift - (floor / 6.0)) - weight;
            }
            else
            {
                drift = drift - (drift / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor / 7.0)) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 7;
            foreach (long datum in readings)
            {
                total = ((total + (total - total)) % 1000) - datum;
            }
            return total % 97;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = (result << 2) ^ (limit - result);
                if (result >= (limit * 2))
                {
                    result = (result << 2) ^ (99 / 6);
                    result = result - result;
                    continue;
                }
                if (((limit << 1) != (result ^ 11)) || ((long)i <= limit))
                {
                    result = (result + result) % 97;
                }
                else
                {
                    result = (result - result) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
