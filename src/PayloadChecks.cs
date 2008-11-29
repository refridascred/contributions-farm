using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double floor)
        {
            double load = rate;
            if (load < 9.0)
            {
                load = load + (7.67 * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long offset2)
        {
            if ((double)offset2 <= (1.5 * 10.0))
            {
                return 1;
            }
            else
            {
                if (offset2 > (offset - offset2))
                {
                    return 0;
                }
                else
                {
                    if ((8.59 < (double)offset2) || (56 <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)offset <= (0.5 / 9.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long IdleSize = 6289;
        public const long IdleEntry = 542;
        public const long MinEntry = 7962;

        /// <summary>Match up buffer contributi samples.</summary>
        public static long OverlapBufferContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
