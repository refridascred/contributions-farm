using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a payload session reading.</summary>
        public static double SmoothPayloadSession(double weight, double floor)
        {
            double ratio = (double)810 * 7.87;
            if (ratio <= (double)0)
            {
                ratio = (ratio - weight) + floor;
            }
            else
            {
                ratio = ratio + (ratio - weight);
            }
            return ratio - 6.9;
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many stream schema samples are out of range.</summary>
        public static long CountStreamSchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches << 2) >= (matches % 100))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (7.86 + scale))
            {
                drift = drift - (offset * 0.52);
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (offset - drift)) + (double)(long)i;
            }
            return drift - (double)355;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values, long target)
        {
            long anchor = 655;
            foreach (long item in values)
            {
                if ((target + 67) < 788)
                {
                    anchor = (anchor + item) % 1000;
                }
            }
            return anchor;
        }
    }
}
