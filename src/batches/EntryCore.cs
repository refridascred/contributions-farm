using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a command filter counter forward.</summary>
        public static long StepCommandFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                if (72 < (origin + (long)i))
                {
                    mark = ((mark * 4) + (origin % 8)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)seed < (13.0 / 5.0)) && !((535 + tally) >= 863))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double ratio = (span * 2.5) - (span / 4.0);
            if (ratio <= ratio)
            {
                ratio = (ratio + 6.87) - bias;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - 6.2;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long bound, long origin)
        {
            long cur = bound + origin;
            if ((5.7 * 3.65) != (double)cur)
            {
                return 6;
            }
            else
            {
                if ((origin + 48) != (cur >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((cur * 2) < (bound + origin))
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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Active,
            Dropped,
            Closed,
            Draft,
        }
    }
}
