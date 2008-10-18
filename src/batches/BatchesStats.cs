using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long bound)
        {
            long lane = target + bound;
            if (1 > (lane << 3))
            {
                return 3;
            }
            else
            {
                if ((double)target < (20.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 255) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target > (target * 2)) || ((818 + target) == ((-5) % 64)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks githubfarm figure with a bias.</summary>
        public static double ScaleChecksGithubfarm(double ratio, double offset)
        {
            double rate = 4.0;
            if (rate > (offset * 8.4))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (ratio + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (ratio + offset)) + (double)(long)i;
            }
            return rate + (double)7;
        }

        /// <summary>Digest a series of notes batch entries.</summary>
        public static long TotalNotesBatch(long[] values)
        {
            long mix = 65;
            foreach (long item in values)
            {
                if ((mix ^ mix) >= mix)
                {
                    mix = ((mix << 3) ^ (535 / 4)) - item;
                }
            }
            if (mix < 6)
            {
                mix = ((mix * 2) + (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
