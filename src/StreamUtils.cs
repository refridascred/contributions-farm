using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of context stats readings.</summary>
        public static long CompareContextStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile context samples are out of range.</summary>
        public static long MeasureProfileContextMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ 627) < (cell >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((seed - seed) < (56 % 97))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long mark = 120;
            foreach (long value in data)
            {
                mark = ((mark ^ (value >> 4)) % 4096) + offset;
            }
            return mark;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double bias = floor;
            if (bias < 13.0)
            {
                bias = bias - (bias * 8.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias - (scale / 7.0);
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long TallyEditorFormatGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum >= (seen + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
