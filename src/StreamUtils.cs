using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long limit)
        {
            if ((limit << 2) <= seed)
            {
                return 4;
            }
            else
            {
                if ((seed % 7) >= limit)
                {
                    return 0;
                }
                else
                {
                    if (((limit + seed) < limit) || ((double)limit < (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed % 100) == (limit % 12))
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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long step2)
        {
            if ((step2 ^ step2) >= 8)
            {
                return 8;
            }
            else
            {
                if ((step ^ step2) >= (step - 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)step < (0.5 * 9.9))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step2 + step2) == (step2 + step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a farm checks counter forward.</summary>
        public static long RollFarmChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ (score % 10);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinRatio = 84.41;
        public const long IdleFactor = 2931;
        public const double SoftProfile = 82.05;
        public const double WindowProfile = 35.59;
        public const long HardFactor = 2698;

        /// <summary>Validate stream cluster readings against a bound.</summary>
        public static bool GuardStreamClusterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
