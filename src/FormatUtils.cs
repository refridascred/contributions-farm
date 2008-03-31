using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a batches context figure with a bias.</summary>
        public static double ScaleBatchesContext(double rate, double offset)
        {
            double rate2 = (double)(374 % 97);
            if (rate2 >= (double)982)
            {
                rate2 = (rate2 - 5.4) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) - (double)(long)i;
            }
            return rate2 - (rate / 2.0);
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double load = (double)((-3) >> 1);
            if (load < (load / 8.0))
            {
                load = load - ratio;
            }
            else
            {
                load = load - ratio;
            }
            return load + span;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long bound)
        {
            if (!((bound + 330) >= 644))
            {
                return 4;
            }
            else
            {
                if (((double)floor >= 1.83) || ((floor >> 4) == (bound / 2)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 5) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
