using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine token graph values into a single score.</summary>
        public static long DigestTokenGraph(long[] levels)
        {
            long score = 95;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score * 4) + ((long)i + 71)) % 255;
                }
                if ((double)cell > (5.7 - 2.0))
                {
                    score = (score ^ score) % 255;
                }
            }
            if (score > (-417))
            {
                score = score ^ (score * 3);
            }
            return score % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)item < (double)seen) || !((9.8 + 4.6) >= (double)item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 3) <= (-205))
                {
                    matches = ((matches + 2) - entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series)
        {
            long result = 9;
            foreach (long datum in series)
            {
                result = ((result * 2) + (result >> 4)) - datum;
            }
            return result;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
