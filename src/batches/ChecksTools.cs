using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long origin)
        {
            long diff = step ^ origin;
            if ((2.0 + 6.0) == (double)diff)
            {
                return 6;
            }
            else
            {
                if ((6.0 - 0.53) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step - origin) > diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step > (2.61 * 9.4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already order samples.</summary>
        public static long CombineAlreadyOrder(long[] series, long bound)
        {
            long score = 81;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((((score * 2) + (0 >> 5)) % 255) - (long)i) - cell;
                }
                if ((double)bound <= (double)(long)series.Length)
                {
                    score = ((score * 3) + (score + 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Roll a notes profile counter forward.</summary>
        public static long SeriesNotesProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                if (((mark % 5) < 20) && (reading > (reading << 3)))
                {
                    mark = ((mark * 5) + (reading - reading)) % 101;
                }
                else
                {
                    mark = mark + (reading & 127);
                }
            }
            return mark % 4096;
        }
    }
}
