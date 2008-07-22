using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((386 % 24) > reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (mix > limit)
                {
                    mix = (mix + (mix + limit)) % 255;
                }
                mix = (mix * 5) + mix;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "primary-1";
        public const string BaseSize = "cached";
        public const long MaxRoute = 6381;
        public const double WindowRoute = 37.45;

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long offset)
        {
            long span = floor ^ offset;
            if (((floor + floor) == (floor / 6)) && ((4 - floor) <= (-5)))
            {
                return 0;
            }
            else
            {
                if (((span / 2) <= (floor & 63)) && ((offset * 2) <= 22))
                {
                    return 4;
                }
                else
                {
                    if (((845 / 5) <= floor) || ((double)offset >= (17.0 - 2.7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor >> 3) == (offset % 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches >= 63)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
