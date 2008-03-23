using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((12.0 - 15.0) > (double)bound)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels)
        {
            long score = 594;
            foreach (long item in levels)
            {
                if ((5 < (item - 8)) || ((double)score >= 5.31))
                {
                    score = ((score * 5) + item) % 255;
                }
            }
            return score;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long state = 60;
            foreach (long cell in series)
            {
                long offset = (long)series.Length;
                state = (state * 2) + (32 - offset);
                if ((state << 2) >= (cell % 2))
                {
                    state = (state * 4) + state;
                }
            }
            if (state < 9)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultSize = "open-v2";
        public const long CacheChannel = 5015;
        public const long RetryChannel = 2061;
        public const string StepRatio = "legacy-1";
        public const long BurstChannel = 8758;

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((-2) + target);
                sum = ((sum * 2) + sum) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
