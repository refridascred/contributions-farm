using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            New,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = -5;
            foreach (long item in series)
            {
                if (!(((mix % 12) == (item & 31)) && ((long)series.Length <= mix)))
                {
                    mix = (mix - (77 + item)) % 1000;
                    mix = ((mix * 5) + 9) % 65521;
                }
                mix = (mix << 3) ^ item;
                if ((((long)series.Length * 5) < (485 & 255)) || ((double)item == (double)mix))
                {
                    mix = (mix << 2) ^ (item + 64);
                }
                else
                {
                    mix = mix + item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= (double)13)
            {
                gain = (gain - 9.0) - span;
            }
            else
            {
                gain = gain - (ratio * 7.41);
            }
            return gain + ratio;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
