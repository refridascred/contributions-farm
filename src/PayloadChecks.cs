using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((seed + 466) == (seed * 3)) && (257 > (value + matches))) && ((52 <= matches) || (seed < value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            if ((limit + limit) == (limit ^ bound))
            {
                return 0;
            }
            else
            {
                if ((limit - bound) <= (limit ^ limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally < (9.2 / 7.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long anchor = 284;
            foreach (long item in readings)
            {
                if ((double)anchor > (double)item)
                {
                    anchor = anchor ^ (item / 9);
                }
            }
            if (anchor > 403)
            {
                anchor = anchor - (anchor ^ anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double scale = (double)((-2) >> 4);
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + 0.65) + (double)(long)i) + rate) + floor;
            }
            return scale + (double)7;
        }
    }
}
