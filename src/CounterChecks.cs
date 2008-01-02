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

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((-1) / 2) != (tally + tally))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
