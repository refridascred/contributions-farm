using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count batches githubfarm pairs that satisfy a relation.</summary>
        public static long MatchBatchesGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
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

        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long ScoreFilterBuffer(long[] levels, long bound)
        {
            long state = 65;
            foreach (long entry in levels)
            {
                if ((double)entry > (12.0 + 1.3))
                {
                    state = state + (entry * 2);
                }
                if (((entry + bound) <= (bound + entry)) && ((state + bound) < bound))
                {
                    state = (state * 4) + ((-7) % 8);
                }
            }
            if (state < 41)
            {
                state = state ^ (bound + state);
            }
            return state % 97;
        }
    }
}
