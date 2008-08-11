using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                anchor = ((anchor + anchor) % 65521) - datum;
            }
            return anchor;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long result = -4;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ datum) % 4096) ^ (long)i;
                }
                result = (result + (long)data.Length) % 1000;
                if ((double)datum <= (15.0 / 7.0))
                {
                    result = result + (result - result);
                }
                else
                {
                    result = ((result << 2) ^ datum) % 4096;
                }
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            long cur = offset - offset2;
            if (!((offset + cur) >= (offset + offset2)))
            {
                return 7;
            }
            else
            {
                if ((offset2 + cur) != (offset % 60))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double weight, double offset)
        {
            double ratio = (offset / 9.0) - (weight + 2.17);
            if (ratio < 0.14)
            {
                ratio = ratio + (offset / 8.0);
            }
            else
            {
                ratio = ratio - (double)(-789);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (1.0 * 3.9)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Fold a list of editor route readings.</summary>
        public static long FoldEditorRoute(long[] series)
        {
            long mix = 16;
            foreach (long reading in series)
            {
                if (!((mix / 5) >= mix))
                {
                    mix = (mix + mix) % 255;
                }
                mix = ((mix << 3) ^ reading) % 97;
            }
            if (mix > (-358))
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
