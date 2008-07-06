using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine notes support values into a single score.</summary>
        public static long CombineNotesSupport(long[] readings)
        {
            long sum = 992;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (sample & 63)) % 65521;
                sum = (sum * 5) + (sum & 15);
                if (sample <= 3)
                {
                    sum = sum + (sum << 1);
                }
                if ((6 + sample) == ((long)readings.Length + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double rate = (double)(3 >> 1);
            if (rate > (double)90)
            {
                rate = ((rate - (7.62 * 3.12)) - weight) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)471;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally / 6) < (value % 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + matches) > entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen <= (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
