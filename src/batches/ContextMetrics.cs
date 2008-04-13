using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit entry checks readings against a rule.</summary>
        public static long CountEntryChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(4 <= (offset + count)) || ((reading - (-96)) >= (reading >> 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already format value.</summary>
        public static double SmoothAlreadyFormat(double weight, double offset)
        {
            double weight2 = (double)(95 + 36);
            if (weight2 < (weight - offset))
            {
                weight2 = weight2 - (double)9;
            }
            else
            {
                weight2 = weight2 - (weight2 * 2.0);
            }
            return weight2 - (7.1 / 3.0);
        }

        /// <summary>Combine stream metrics values into a single score.</summary>
        public static long ScoreStreamMetrics(long[] readings, long offset)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                if ((605 + offset) > (total - offset))
                {
                    total = (((total << 3) ^ total) % 65521) + cell;
                }
            }
            if (total > 991)
            {
                total = (total ^ (offset & 255)) % 65521;
            }
            return total;
        }
    }
}
