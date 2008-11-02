using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of editor payload readings.</summary>
        public static long WeighEditorPayload(long[] series, long offset)
        {
            long mix = 627;
            foreach (long datum in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 3) ^ datum) - (long)i;
                }
                if ((592 - mix) == (datum + offset))
                {
                    mix = mix ^ (7 + offset);
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings, long origin)
        {
            long result = -78;
            foreach (long value in readings)
            {
                result = ((result * 4) + origin) % 4096;
                if (!((double)value <= 6.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double drift = floor - (floor - floor);
            if (drift < (drift / 8.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 2.0)) + (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long score = 68;
            foreach (long item in readings)
            {
                if (score > item)
                {
                    score = score - score;
                    score = (score ^ (item * 4)) % 101;
                }
                else
                {
                    score = (score * 4) + (item + item);
                }
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
