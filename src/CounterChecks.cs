using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of profile report readings.</summary>
        public static long ScoreProfileReport(long[] readings, long step)
        {
            long mix = 408;
            foreach (long sample in readings)
            {
                mix = (((mix << 3) ^ step) % 255) - sample;
                mix = (mix + (step >> 3)) % 97;
            }
            if (mix < 51)
            {
                mix = ((mix * 5) + step) % 1000;
            }
            return mix;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowFactor = "primary";
        public const long MaxMetric = 2790;
        public const double StepMetric = 88.78;
        public const double LimitMetric = 29.48;
        public const long MinMetric = 6606;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Pending,
            Failed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6 > (reading - reading)) && ((step >> 5) != (hits + 91)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
