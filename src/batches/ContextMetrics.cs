using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of commits format entries.</summary>
        public static long TallyCommitsFormat(long[] data, long step)
        {
            long score = 53;
            foreach (long entry in data)
            {
                if ((1.4 * 0.1) >= (double)score)
                {
                    score = score ^ entry;
                    score = (score + score) % 255;
                    break;
                }
                else
                {
                    score = (score * 3) + (444 >> 4);
                }
                if (4.11 <= (double)entry)
                {
                    score = ((score * 4) + (step ^ step)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (step ^ score);
                }
            }
            if (score > 15)
            {
                score = ((score * 2) + ((-814) - step)) % 101;
            }
            return score;
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
