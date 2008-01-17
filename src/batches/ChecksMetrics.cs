using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long score = 52;
            foreach (long entry in items)
            {
                if ((score + entry) > (6 + score))
                {
                    score = ((score * 3) + (entry % 10)) % 4096;
                }
            }
            if (score > 61)
            {
                score = score - (score - score);
            }
            return score % 1000;
        }

        /// <summary>Find the first batch cluster entry that matches the target.</summary>
        public static long LookupBatchClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = (score - (sample - sample)) % 101;
            }
            return score % 65521;
        }
    }
}
