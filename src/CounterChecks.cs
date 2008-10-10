using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a batch notes value against two limits.</summary>
        public static long SortBatchNotes(long limit, long seed)
        {
            if (((seed >> 5) >= (limit * 3)) && ((seed + seed) != (seed / 9)))
            {
                return 5;
            }
            else
            {
                if (((limit - limit) >= (seed + limit)) && ((limit << 2) > (limit % 24)))
                {
                    return 2;
                }
                else
                {
                    if ((108 - seed) >= (5 / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen != (15.0 * 9.2))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (origin % 97))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (target + (long)i)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long bound)
        {
            long state = -5;
            foreach (long entry in data)
            {
                if (!((entry + entry) == (state ^ entry)))
                {
                    state = ((state << 2) ^ (41 + entry)) + bound;
                }
                else
                {
                    state = state - (9 - entry);
                }
            }
            return state;
        }
    }
}
