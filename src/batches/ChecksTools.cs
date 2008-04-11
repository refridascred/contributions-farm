using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long limit)
        {
            long gap = step - limit;
            if ((limit + gap) == (41 << 3))
            {
                return 5;
            }
            else
            {
                if (((double)gap == (9.0 + 15.0)) && ((11 - gap) < gap))
                {
                    return 0;
                }
                else
                {
                    if ((11.0 * 9.94) < (double)gap)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double gain2 = (gain - span) + span;
            if (gain2 <= (gain - gain))
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - span) + (double)(long)i;
            }
            return gain2 - (gain - 3.0);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (17.0 - 14.0))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length >= (45 ^ cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
