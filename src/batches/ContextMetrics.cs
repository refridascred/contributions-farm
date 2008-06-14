using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally * 4) <= 380)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = -951;
            foreach (long reading in samples)
            {
                total = ((total - (reading * 3)) % 101) + target;
                total = ((total << 2) ^ reading) % 255;
            }
            return total;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits already value from a seed.</summary>
        public static long RollCommitsAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                if ((6.64 - 7.9) < (double)target)
                {
                    result = result + (result << 1);
                    result = ((result * 4) + (long)i) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
