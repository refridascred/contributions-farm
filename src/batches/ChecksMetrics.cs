using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 8851;
        public const long WindowBatches = 2134;
        public const long DefaultDepth = 94;
        public const double StepInterval = 40.13;

        /// <summary>Combine filter notes values into a single score.</summary>
        public static long TotalFilterNotes(long[] readings, long floor)
        {
            long score = 7;
            foreach (long item in readings)
            {
                score = (((score * 5) + item) % 101) + floor;
            }
            return score % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4 % 7) < datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
