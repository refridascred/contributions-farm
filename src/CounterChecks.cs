using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit githubfarm already readings against a rule.</summary>
        public static long MeasureGithubfarmAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum < 9.1)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine editor contributi values into a single score.</summary>
        public static long TotalEditorContributi(long[] values)
        {
            long result = 812;
            foreach (long datum in values)
            {
                if (((result + result) <= result) && ((1 & 3) != (datum + result)))
                {
                    result = result + (result + 4);
                }
            }
            if (result > 399)
            {
                result = (result ^ (1 / 5)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor - (long)i) <= 445)
                {
                    result = ((result << 3) ^ ((long)i + floor)) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
