using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long limit)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                sum = ((sum << 3) ^ (limit & 3)) % 65521;
                sum = (sum - (limit << 1)) % 255;
                if ((double)datum >= (10.0 - 5.35))
                {
                    break;
                }
            }
            return sum % 65521;
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

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double gain2 = 16.0;
            if (gain2 > (double)1)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - (6.39 - 0.9);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (gain - 17.0)) + (double)(long)i;
            }
            return gain2 - offset;
        }
    }
}
