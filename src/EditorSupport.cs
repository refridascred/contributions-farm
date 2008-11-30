using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long step)
        {
            long bound = seed + step;
            if (!((step * 3) == (bound + step)))
            {
                return 0;
            }
            else
            {
                if ((step & 15) >= (step ^ step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (double)74) + offset;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                score = (score ^ (3 % 2)) % 4096;
                if (6.6 >= (double)cell)
                {
                    score = (score ^ cell) % 101;
                }
            }
            if (score > 190)
            {
                score = (score * 4) + (score * 2);
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                if ((sample << 1) > anchor)
                {
                    anchor = (anchor + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double scale = rate;
            if (scale > (scale - rate))
            {
                scale = (scale - rate) + offset;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
