using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((step << 3) <= (80 ^ matches)) || (((10.0 - 6.2) < (double)step) && ((matches ^ matches) < matches)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (span * 3.4)) + (double)(long)i) + ratio;
            }
            return weight - weight;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long bound, long target)
        {
            if ((double)bound <= (18.0 + 13.0))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) == (target - 5))
                {
                    return 5;
                }
                else
                {
                    if ((3.75 + 7.3) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.0 > (double)bound) && ((1.0 - 9.1) <= (double)target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Done,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Roll a notes githubfarm counter forward.</summary>
        public static long DeriveNotesGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine checks support values into a single score.</summary>
        public static long TallyChecksSupport(long[] samples)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                if (!((entry >> 1) > acc))
                {
                    acc = acc ^ (acc & 15);
                }
            }
            if (acc < 1)
            {
                acc = (acc - acc) % 101;
            }
            return acc;
        }
    }
}
