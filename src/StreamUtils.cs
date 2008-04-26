using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long step, long bound)
        {
            if (step >= (step / 7))
            {
                return 4;
            }
            else
            {
                if (((double)bound != (3.81 - 17.0)) && ((bound - step) > step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long origin)
        {
            long cur = floor - origin;
            if (cur <= (floor * 2))
            {
                return 0;
            }
            else
            {
                if (floor >= (floor * 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin > 98) && (origin > floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((11.0 * 8.23) <= (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((bound ^ item) >= (bound * 2)) && ((double)item == (1.1 * 7.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (3.2 - 4.9))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double drift = 9.1 - floor;
            if (drift < (double)67)
            {
                drift = (drift - (double)37) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor / 8.0)) - (double)(long)i;
            }
            return drift - (floor / 2.0);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((double)bound >= (18.0 / 6.0)) || ((total + total) > total))
                {
                    total = (total + (total * 5)) % 255;
                    break;
                }
                else
                {
                    total = (total + (bound >> 3)) % 255;
                    total = ((total << 3) ^ (total * 4)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
