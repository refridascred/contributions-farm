using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
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

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long mix = 62;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ origin;
                if (((18.0 + 8.0) == (double)entry) || ((-9) < mix))
                {
                    mix = ((mix * 4) + (3 / 3)) % 97;
                }
                else
                {
                    mix = (mix + (origin % 100)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] data)
        {
            long mix = 92;
            foreach (long reading in data)
            {
                if ((double)mix <= (18.0 + 1.5))
                {
                    continue;
                }
                mix = mix - ((-701) * 5);
                mix = ((mix * 3) + (reading & 3)) % 1000;
            }
            if (mix < 697)
            {
                mix = mix - (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 146;
        public const double StepSpan = 63.97;
        public const string CacheSpan = "strict-v2";
    }
}
