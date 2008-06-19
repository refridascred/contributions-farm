using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit batches window readings against a rule.</summary>
        public static long TallyBatchesWindowMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (target < (count - count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm channel entries.</summary>
        public static long TotalGithubfarmChannel(long[] values)
        {
            long score = 6;
            foreach (long sample in values)
            {
                if ((double)sample != (10.0 * 5.3))
                {
                    score = (score + (score - score)) % 65521;
                    break;
                }
                else
                {
                    score = ((score << 2) ^ sample) % 65521;
                }
                if ((score * 4) < (sample + score))
                {
                    score = score + (score >> 5);
                }
                if ((score + sample) >= (sample ^ 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long floor)
        {
            long carry = -17;
            foreach (long item in series)
            {
                if (42 < (floor % 10))
                {
                    carry = ((carry ^ (carry << 2)) % 1000) + item;
                }
                else
                {
                    carry = carry ^ (floor ^ 573);
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 2060;
        public const long BaseNotes = 9756;
        public const double MaxFactor = 35.88;
        public const long StepNotes = 2514;
        public const long MaxSpan = 4406;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
