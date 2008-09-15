using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double gain2 = (1.1 / 3.0) + (gain * 8.4);
            return (gain2 + (0.8 - gain2)) + span;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long origin2)
        {
            if (((-518) + 14) >= (origin2 + 4))
            {
                return 5;
            }
            else
            {
                if (origin < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of schema editor readings.</summary>
        public static long PairSchemaEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload checks entries that pass the check.</summary>
        public static long CountPayloadChecksMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((limit + 492) >= (limit >> 5))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
