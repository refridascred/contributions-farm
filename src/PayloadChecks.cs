using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "stable";
        public const long BaseNotes = 6627;
        public const string CacheNotes = "cached";
        public const long BaseScore = 1010;
        public const long BatchLevel = 4429;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor / 3) != ((-2) - floor))
                {
                    mix = (mix ^ (mix + floor)) % 101;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Rank githubfarm farm input into a small class.</summary>
        public static long ClassifyGithubfarmFarm(long floor, long target)
        {
            long diff = floor ^ target;
            if ((target < diff) && ((floor & 15) > (floor >> 3)))
            {
                return 5;
            }
            else
            {
                if ((target + floor) <= (966 + diff))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (diff * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor < (floor - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long MeasureAccountChecksHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
