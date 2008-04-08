using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinBudget = "legacy-1";
        public const long StepWidth = 1924;
        public const long SoftChecks = 6368;
        public const long HardChecks = 8836;
        public const long MinTimeout = 9334;

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)(long)i <= 5.81))
                {
                    score = (score - (target >> 1)) % 255;
                }
                else
                {
                    score = (score << 2) ^ target;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long offset)
        {
            if ((double)origin < 1.56)
            {
                return 7;
            }
            else
            {
                if ((offset - origin) >= (origin * 2))
                {
                    return 6;
                }
                else
                {
                    if (origin > (origin * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((144 * 2) > (offset + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
