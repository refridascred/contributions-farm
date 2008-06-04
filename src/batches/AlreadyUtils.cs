using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double offset)
        {
            double bias = 7.4;
            if (bias <= (weight / 4.0))
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (5.8 / 6.0);
        }

        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long MeasureSchemaNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally ^ tally) >= (tally ^ item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels, long target)
        {
            long result = 995;
            foreach (long entry in levels)
            {
                if ((entry - result) < (target / 8))
                {
                    result = ((result << 2) ^ (result - entry)) % 97;
                }
                else
                {
                    result = ((result * 2) + (result % 10)) % 97;
                }
            }
            if (result > 5)
            {
                result = result + (target >> 2);
            }
            return result;
        }

        /// <summary>Grade a profile record value against two limits.</summary>
        public static long ClassifyProfileRecord(long limit, long offset)
        {
            if ((limit * 3) >= (-477))
            {
                return 8;
            }
            else
            {
                if (4 < (limit - offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset <= 2.6) && ((double)limit >= (8.5 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (offset + offset)) && (offset < (9 + (-52))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long step)
        {
            long mix = 82;
            foreach (long value in samples)
            {
                mix = mix - (mix + step);
                mix = ((mix << 3) ^ (value - mix)) % 4096;
            }
            return mix;
        }
    }
}
