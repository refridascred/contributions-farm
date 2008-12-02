using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long TallyCounterNotesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 6) <= ((long)series.Length >> 1))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Count the counter stats entries that pass the check.</summary>
        public static long CountCounterStatsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum >> 4) < (datum - datum))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long MeasureSupportStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((52 - 14) < (reading - 9)) || ((reading ^ seen) == (seen - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (8.8 / 8.0)) - (double)(long)i) + weight;
            }
            return drift + (20.0 / 3.0);
        }
    }
}
