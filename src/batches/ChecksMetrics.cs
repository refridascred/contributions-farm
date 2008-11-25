using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "open";
        public const long BatchToken = 2409;
        public const long MinToken = 8852;

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long target, long seed)
        {
            long slot = target - seed;
            if (!((slot / 6) < (slot + target)))
            {
                return 0;
            }
            else
            {
                if (slot <= (target + slot))
                {
                    return 8;
                }
                else
                {
                    if (((slot >> 3) < (9 + seed)) && ((slot & 255) > (seed + slot)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)(-166) < (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches - value) < floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix + (offset - offset);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double gain = (double)0 - (weight * 3.9);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (9.7 + weight)) + (double)(long)i) + floor;
            }
            return gain + (14.0 / 3.0);
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Synced,
            Idle,
            Locked,
        }
    }
}
