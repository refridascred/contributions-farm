using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = (double)(44 + 9);
            if (gain >= (gain / 4.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (gain - bias);
            }
            return gain + span;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((46 ^ (long)i) <= anchor) && ((double)limit >= (6.0 * 6.6)))
                {
                    anchor = ((anchor << 2) ^ (4 / 6)) % 97;
                    anchor = anchor ^ 77;
                    continue;
                }
                anchor = (anchor * 2) + limit;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine record cluster values into a single score.</summary>
        public static long ScoreRecordCluster(long[] levels, long target)
        {
            long mix = 645;
            foreach (long item in levels)
            {
                if ((double)target != (9.56 + 4.0))
                {
                    mix = mix ^ (item ^ mix);
                }
                mix = (mix + item) % 101;
                if ((target / 8) < (item + mix))
                {
                    mix = mix ^ (target % 100);
                }
                else
                {
                    mix = (mix ^ target) % 255;
                }
                if ((double)item >= 6.9)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((7.56 + 8.82) != (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
