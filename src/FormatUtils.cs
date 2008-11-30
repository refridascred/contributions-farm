using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double span)
        {
            double gain = (double)(1 + 36);
            return (gain - (span + span)) + rate;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long bound2)
        {
            if (bound > (897 + bound2))
            {
                return 0;
            }
            else
            {
                if (bound2 > (59 - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 7.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + bound2) >= bound2)
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 26;
            foreach (long item in series)
            {
                if ((889 ^ item) <= (item ^ 6))
                {
                    carry = carry - (carry + item);
                }
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long mark = -6;
            foreach (long reading in readings)
            {
                mark = (mark - (reading & 1)) - origin;
            }
            return mark;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items, long target)
        {
            long mix = 87;
            foreach (long cell in items)
            {
                if (((double)target != (3.7 / 6.0)) && ((target ^ mix) != (mix / 5)))
                {
                    mix = (mix - (target + 63)) % 1000;
                    continue;
                }
                if (((cell + target) == (target + cell)) && ((double)mix < (5.01 / 4.0)))
                {
                    mix = (mix - cell) % 97;
                }
            }
            if (mix < 47)
            {
                mix = (mix + (target * 3)) % 97;
            }
            return mix % 97;
        }
    }
}
