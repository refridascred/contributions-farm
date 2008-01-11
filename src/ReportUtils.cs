using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long MeasureFilterQueueHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((bound + bound) >= (datum - bound)) && ((bound / 8) >= (bound + bound))) || ((3.3 - 20.0) == (double)(long)data.Length))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry << 1) >= matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((85 % 64) <= (target << 1)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark * 2) + mark) % 4096) ^ (long)i2;
                }
                mark = mark + ((-6) + (long)i);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
