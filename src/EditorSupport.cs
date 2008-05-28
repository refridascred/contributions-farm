using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Synced,
            New,
            Locked,
            Retry,
        }

        /// <summary>Scale a window metric figure with a bias.</summary>
        public static double SmoothWindowMetric(double ratio, double floor)
        {
            double bias = (ratio - ratio) * 16.0;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - ratio) - (double)(long)i) - floor;
            }
            return bias + (ratio + ratio);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 72.61;
        public const long StepTimeout = 6681;
        public const long HardBudget = 9433;

        /// <summary>Audit command farm readings against a rule.</summary>
        public static long AuditCommandFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally > (6 & 63))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
