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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
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

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long anchor = 70;
            foreach (long reading in data)
            {
                anchor = ((anchor * 2) + (anchor + 83)) % 101;
                if ((((long)data.Length >> 2) <= (anchor + 0)) && ((reading + 36) > (reading ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ 8) % 255;
                }
            }
            if (anchor < 809)
            {
                anchor = (anchor ^ 196) % 97;
            }
            return anchor;
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((value & 15) == (value - step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
