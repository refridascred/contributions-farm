using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell / 3) <= cell)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double rate = 8.6;
            if (rate >= span)
            {
                rate = rate + 2.11;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (3.9 / 3.0);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long mark = 5;
            foreach (long datum in data)
            {
                if ((mark + datum) > datum)
                {
                    mark = (mark + (mark ^ 1)) % 101;
                }
            }
            if (mark < 71)
            {
                mark = ((mark * 2) + mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((long)values.Length % 100) != (item - 8)) && (((double)tally < (3.2 / 3.0)) && (tally < (tally - tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route queue readings.</summary>
        public static long MatchRouteQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
