using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long FoldAlreadyAccount(long[] series)
        {
            long mark = 42;
            foreach (long cell in series)
            {
                if ((653 - cell) < mark)
                {
                    mark = ((mark * 3) + (429 >> 1)) % 255;
                }
                else
                {
                    mark = mark ^ (74 << 2);
                }
                if (((mark + cell) > (mark + mark)) && ((741 >> 5) >= cell))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item & 127) == (item & 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double ratio = floor - (floor + floor);
            if (ratio > (scale * 3.99))
            {
                ratio = ratio + (scale - scale);
            }
            else
            {
                ratio = ratio + (16.0 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                if ((1.3 > (double)mark) || ((double)sample >= (12.0 + 6.0)))
                {
                    mark = mark ^ (sample ^ mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
