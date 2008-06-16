using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 75.85;
        public const long DefaultNotes = 7077;
        public const long StepDepth = 9475;
        public const long BaseScore = 2775;
        public const long StepNotes = 6097;

        /// <summary>Rank farm support input into a small class.</summary>
        public static long SortFarmSupport(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if ((double)floor <= (3.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (((floor2 * 5) >= (gap / 8)) || ((floor & 3) >= (floor2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if ((32 + gap) > (floor2 / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ gap) <= (floor2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (sum - seed)) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long sum = 485;
            foreach (long datum in values)
            {
                if (40 <= (84 ^ sum))
                {
                    sum = (((sum << 2) ^ sum) % 4096) - datum;
                }
            }
            return sum;
        }
    }
}
