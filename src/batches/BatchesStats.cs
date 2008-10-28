using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Stale,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (bound > 543)
            {
                return 4;
            }
            else
            {
                if ((double)diff > (3.0 / 7.0))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 100) == (bound + origin)) && ((double)diff <= (8.05 - 6.3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((4 - origin) != (origin & 63)) || ((origin * 3) == (bound & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two report record measurements.</summary>
        public static double ProjectReportRecord(double scale, double bias)
        {
            double weight = (double)(35 ^ 76);
            if (weight > scale)
            {
                weight = weight + (scale - scale);
            }
            else
            {
                weight = weight - (double)385;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (10.0 * 2.7)) - (double)(long)i;
            }
            return weight + bias;
        }
    }
}
