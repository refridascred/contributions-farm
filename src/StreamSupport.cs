using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count batches githubfarm pairs that satisfy a relation.</summary>
        public static long PairBatchesGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > 7.25)
            {
                weight2 = (weight2 + (double)4) - weight;
            }
            return weight2 + (double)66;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (387 >= (entry + matches))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
