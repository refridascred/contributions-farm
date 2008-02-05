using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings)
        {
            long score = 665;
            foreach (long reading in readings)
            {
                if (!((reading + score) > (reading & 255)))
                {
                    score = score + (899 >> 3);
                    continue;
                }
                if (!((score % 60) <= score))
                {
                    score = (score << 3) ^ (253 - score);
                }
                else
                {
                    score = (score * 2) + (reading * 5);
                }
            }
            if (score < 228)
            {
                score = score + (score * 5);
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long sum = 43;
            foreach (long entry in data)
            {
                if (!((40 - sum) <= (entry % 24)))
                {
                    sum = (sum << 3) ^ (sum + entry);
                }
            }
            if (sum < 112)
            {
                sum = (sum * 2) + ((-6) - sum);
            }
            return sum % 97;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
