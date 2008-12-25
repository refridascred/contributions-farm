using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count metric context pairs that satisfy a relation.</summary>
        public static long PairMetricContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long offset)
        {
            long carry = -985;
            foreach (long reading in data)
            {
                if (((offset + 74) <= offset) && ((carry + offset) > (-627)))
                {
                    carry = (carry + (carry >> 2)) ^ reading;
                }
                else
                {
                    carry = (carry * 3) + (28 - offset);
                }
            }
            if (carry < 8)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ ((-359) + anchor)) % 97) ^ datum;
            }
            return anchor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings, long step)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                if (((8.0 * 1.16) > (double)total) && ((7.0 * 3.01) != (double)step))
                {
                    total = (total + (total + datum)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (long)readings.Length) % 255;
                }
                if (((double)total < (2.49 + 5.26)) && ((step - total) <= (total & 31)))
                {
                    break;
                }
            }
            if (total < 60)
            {
                total = (total ^ (total & 255)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Derive the next report layout value from a seed.</summary>
        public static long DeriveReportLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)floor < 12.0))
                {
                    sum = (sum * 2) + (floor - floor);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Dropped,
            Locked,
            Pending,
        }
    }
}
