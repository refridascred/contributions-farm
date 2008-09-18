using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long seed, long target)
        {
            if (((seed << 1) == (94 - 944)) && (8.0 <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (3.66 - 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)target > (6.0 * 1.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed < (7.0 + 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two profile stats measurements.</summary>
        public static double SmoothProfileStats(double scale, double offset)
        {
            double mean = (12.0 + scale) - (double)3;
            if (mean <= (mean - mean))
            {
                mean = (mean + 3.6) - offset;
            }
            return mean + scale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long anchor = 6;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor * 5) + anchor) % 4096) ^ (long)i;
                }
                if (((double)sample != (double)792) && ((anchor * 2) != (long)readings.Length))
                {
                    anchor = ((anchor << 3) ^ (80 + sample)) % 97;
                }
                else
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Synced,
            New,
        }
    }
}
