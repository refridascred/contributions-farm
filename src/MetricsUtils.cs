using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= 2.0))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema farm entries.</summary>
        public static long WeighSchemaFarm(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = ((state * 4) + (state & 127)) % 4096;
                state = ((state << 3) ^ (value + value)) % 4096;
                if ((value - (long)levels.Length) <= ((long)levels.Length & 7))
                {
                    state = ((state << 3) ^ (state + state)) % 4096;
                }
                else
                {
                    state = state ^ (state ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = total - (long)i;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next queue notes value from a seed.</summary>
        public static long SeriesQueueNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
