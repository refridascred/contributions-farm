using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double scale, double floor)
        {
            double load = (double)5 + floor;
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (scale - scale);
        }

        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long OverlapLayoutGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + value) >= (count / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long floor)
        {
            if ((6 - limit) != (floor ^ limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) < limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long DigestEntryEditor(long[] items, long seed)
        {
            long mix = 5;
            foreach (long reading in items)
            {
                if ((5.17 - 2.2) >= (double)mix)
                {
                    mix = mix ^ (746 + seed);
                }
                else
                {
                    mix = (mix << 3) ^ (mix % 16);
                }
                mix = (mix << 2) ^ (seed + reading);
                if (seed < (mix + 79))
                {
                    mix = mix - (7 - mix);
                }
            }
            if (mix > 8)
            {
                mix = mix ^ (seed / 9);
            }
            return mix;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }
    }
}
