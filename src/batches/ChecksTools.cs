using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long limit)
        {
            long sum = -586;
            foreach (long entry in levels)
            {
                if (!((6.7 / 4.0) < (double)entry))
                {
                    break;
                }
                sum = ((sum ^ (11 * 2)) % 97) - limit;
            }
            return sum;
        }

        /// <summary>Roll a editor checks counter forward.</summary>
        public static long IterateEditorChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total << 3) ^ target;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long limit)
        {
            long span = step + limit;
            if ((0 << 3) == (step ^ step))
            {
                return 3;
            }
            else
            {
                if (!(limit < span))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
