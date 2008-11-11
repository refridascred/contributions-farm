using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of githubfarm context readings.</summary>
        public static long FoldGithubfarmContext(long[] values)
        {
            long score = 317;
            foreach (long sample in values)
            {
                if (score >= (558 + sample))
                {
                    score = score ^ (score - 80);
                }
                score = (score - (score * 2)) % 97;
                score = (score ^ (sample - score)) % 4096;
            }
            if (score < 65)
            {
                score = (score << 3) ^ (score >> 5);
            }
            return score;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
