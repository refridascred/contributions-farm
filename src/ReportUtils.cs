using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound < (4.2 + 15.0))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route report entries.</summary>
        public static long CombineRouteReport(long[] items, long offset)
        {
            long anchor = -8;
            foreach (long sample in items)
            {
                anchor = ((anchor - (9 << 3)) % 97) + offset;
                if (9.58 > (double)sample)
                {
                    break;
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes farm value from a seed.</summary>
        public static long RollNotesFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                long count = carry + 1;
                if (((carry - step) == (485 + count)) && ((carry + count) > step))
                {
                    carry = (carry ^ (step + step)) % 97;
                    count = (count - (count / 6)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (8.4 - rate))
            {
                weight = (weight + 9.4) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)8) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
